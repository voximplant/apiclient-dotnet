using System;
using System.IO;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Voximplant.API.Response;
using System.Linq;

namespace Voximplant.API
{
    public partial class VoximplantAPI
    {
        private readonly ClientConfiguration _configuration;
        private readonly Credentials _credentials;
        private readonly IDictionary<ILogger, LogSeverity> _loggers;

        /// <summary>
        /// 
        /// </summary>
        public VoximplantAPI() : this(new ClientConfiguration())
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public VoximplantAPI(ClientConfiguration configuration)
        {
            _loggers = new Dictionary<ILogger, LogSeverity>();
            _configuration = configuration;
            _credentials = Credentials.Load(_configuration.KeyFile);
        }

        /// <summary>
        /// Register ILogger with specific LogSeverity
        /// </summary>
        /// <param name="severity">Severity of events, that will be passed to ILogger instance</param>
        /// <param name="logger">Instance of ILogger</param>
        public void AddLogger(LogSeverity severity, ILogger logger)
        {
            if (_loggers.ContainsKey(logger))
            {
                _loggers[logger] = severity;
            }
            else
            {
                _loggers.Add(logger, severity);
            }
        }

        /// <summary>
        /// Removes logger
        /// </summary>
        /// <param name="logger">Instance of ILogger</param>
        public void RemoveLogger(ILogger logger)
        {
            if (_loggers.ContainsKey(logger))
            {
                _loggers.Remove(logger);
            }
        }

        private void Log(LogSeverity severity, string message)
        {
            foreach (var logger in _loggers)
            {
                if ((int)logger.Value >= (int)severity)
                {
                    logger.Key.Log(severity, message);
                }
            }
        }

        public string GetAuthorizationHeader()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var credentials = new SigningCredentials(_credentials.PrivateKey, SecurityAlgorithms.RsaSha256);

            var token = tokenHandler.CreateJwtSecurityToken(issuer: _credentials.AccountId.ToString(),
                // issuedAt:DateTime.Now,
                // expires:DateTime.Now,
                signingCredentials: credentials);

            var tokenString = tokenHandler.WriteToken(token);

            return $"Bearer {tokenString}";
        }

        private Uri RequestUri(string action)
        {
            var uri = $"http{(_configuration.UseHTTPS ? "s" : "")}://{_configuration.APIHost}/platform_api/{action}";
            return new Uri(uri);
        }

        private MultipartFormDataContent MakeRequestBody(string node, IDictionary<string, object> request)
        {
            var requestBody = new MultipartFormDataContent();

            foreach (var item in request)
            {
                if (item.Value == null)
                {
                    continue;
                }
                if(item.Value is Stream){
                    StreamContent requestBodyStreamContent = new StreamContent((Stream) item.Value);
                    requestBody.Add(requestBodyStreamContent, item.Key);
                } else { 
                    string stringValue = (string)item.Value;                     
                    StringContent requestBodyContent = new StringContent(stringValue);
                    requestBody.Add(requestBodyContent, item.Key);
                }
            }
            
            return requestBody;
        }

        private async Task<HttpResponseMessage> SendRequestAsync(HttpClient client, string node, MultipartFormDataContent requestBody, IDictionary<string, object> request)
        {
            var uri = RequestUri(node);
            var authHeader = GetAuthorizationHeader();
            
            Log(LogSeverity.Info, $"Requesting: {uri}, Authorization: {authHeader}");
            Log(LogSeverity.Verbose, $"Body: {string.Join(",", request)}");

            client.DefaultRequestHeaders.Add("Authorization", authHeader);
            var response = await client.PostAsync(uri, requestBody);
            
            Log(LogSeverity.Info, $"Response code: {(int)response.StatusCode}");

            return response;
        }

        private async Task<TResponse> PerformRequest<TResponse>(string node, IDictionary<string, object> request, FileStream writeStream = null)
            where TResponse : BaseResponse, new()
        {
            using (var client = new HttpClient())
            {
                request["cmd"] = node;

                MultipartFormDataContent requestBody = MakeRequestBody(node, request);

                var response = await SendRequestAsync(client, node, requestBody, request);
                Stream resultStream = null;
                string resultString;
                if (string.Equals(response.Content.Headers.ContentType?.MediaType, 
                 "application/octet-stream", 
                 StringComparison.OrdinalIgnoreCase)){
                    Log(LogSeverity.Info, $"Response code: {(int)response.StatusCode}");
                    resultStream = await response.Content.ReadAsStreamAsync();

                    var fakeResp = new TResponse();
                    resultString = JsonConvert.SerializeObject(fakeResp);
                } else {
                    resultString = await response.Content.ReadAsStringAsync();
                    Log(LogSeverity.Verbose, $"Response: {resultString}");
                }

                var result = JsonConvert.DeserializeObject<TResponse>(resultString, new JsonSerializerSettings
                {
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                    TraceWriter = _configuration.TraceWriter,
                });

                if (result == null)
                {
                    Log(LogSeverity.Error, "Empty response");
                    throw new VoximplantException("Empty response");
                }

                if (!result.HasError()) {
                    if(resultStream != null){
                        dynamic dynamicResult = result;
                        dynamicResult.FileContent = resultStream;
                        return dynamicResult;
                    }
                    return result;
                } 
                
                Log(LogSeverity.Error, result.GetError().Msg);
                throw new VoximplantException(result.GetError().Msg, result.GetError().Code);
            }
        }
    }
}
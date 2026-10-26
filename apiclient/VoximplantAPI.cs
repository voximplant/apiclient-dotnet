using System;
using System.IO;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Voximplant.API.Response;
using System.Linq;

namespace Voximplant.API
{
    public partial class VoximplantAPI
    {
        /// <summary>
        /// Reused for every request that does not supply its own client.
        /// One handler keeps sockets in a pool instead of opening a new one per call.
        /// </summary>
        private static readonly HttpClient SharedHttpClient = new HttpClient();

        private readonly ClientConfiguration _configuration;
        private readonly Credentials _credentials;
        private readonly IDictionary<ILogger, LogSeverity> _loggers;
        private readonly Func<HttpClient> _createHttpClient;

        /// <summary>
        /// Creates an API client with default configuration.
        /// Requests reuse one process-wide <see cref="HttpClient"/>.
        /// </summary>
        public VoximplantAPI() : this(new ClientConfiguration())
        {
        }

        /// <summary>
        /// Creates an API client with the specified configuration.
        /// When <see cref="ClientConfiguration.CreateHttpClient"/> is set, that delegate
        /// supplies the <see cref="HttpClient"/> and the library does not dispose it.
        /// Otherwise requests reuse one process-wide <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="configuration"></param>
        public VoximplantAPI(ClientConfiguration configuration)
            : this(configuration, configuration?.CreateHttpClient)
        {
        }

        /// <summary>
        /// Creates an API client that delegates <see cref="HttpClient"/> creation to the caller.
        /// The library does not dispose clients returned by <paramref name="createHttpClient"/>.
        /// </summary>
        /// <param name="createHttpClient">Delegate that returns an <see cref="HttpClient"/>.</param>
        public static VoximplantAPI Create(Func<HttpClient> createHttpClient)
        {
            return Create(new ClientConfiguration(), createHttpClient);
        }

        /// <summary>
        /// Creates an API client that delegates <see cref="HttpClient"/> creation to the caller.
        /// <paramref name="createHttpClient"/> is used even when
        /// <see cref="ClientConfiguration.CreateHttpClient"/> is also set.
        /// The library does not dispose clients returned by <paramref name="createHttpClient"/>.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="createHttpClient">Delegate that returns an <see cref="HttpClient"/>.</param>
        public static VoximplantAPI Create(ClientConfiguration configuration, Func<HttpClient> createHttpClient)
        {
            if (createHttpClient == null)
            {
                throw new ArgumentNullException(nameof(createHttpClient));
            }

            return new VoximplantAPI(configuration, createHttpClient);
        }

        private VoximplantAPI(ClientConfiguration configuration, Func<HttpClient> createHttpClient)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            _loggers = new Dictionary<ILogger, LogSeverity>();
            _configuration = configuration;
            _createHttpClient = createHttpClient;
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
            
            var accountId = _credentials.AccountId.ToString();
            if (_configuration.AccountId != 0)
            {
                accountId = _configuration.AccountId.ToString();
            }

            var token = tokenHandler.CreateJwtSecurityToken(issuer: accountId,
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

        private HttpClient GetHttpClient()
        {
            if (_createHttpClient == null)
            {
                return SharedHttpClient;
            }

            var customClient = _createHttpClient();
            if (customClient == null)
            {
                throw new InvalidOperationException("CreateHttpClient returned null.");
            }

            return customClient;
        }

        private async Task<HttpResponseMessage> SendRequestAsync(HttpClient client, string node, MultipartFormDataContent requestBody, IDictionary<string, object> request)
        {
            var uri = RequestUri(node);
            var authHeader = GetAuthorizationHeader();
            
            Log(LogSeverity.Info, $"Requesting: {uri}, Authorization: {authHeader}");
            Log(LogSeverity.Verbose, $"Body: {string.Join(",", request)}");

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, uri))
            {
                httpRequest.Content = requestBody;
                httpRequest.Headers.TryAddWithoutValidation("Authorization", authHeader);

                var response = await client.SendAsync(httpRequest);

                Log(LogSeverity.Info, $"Response code: {(int)response.StatusCode}");

                return response;
            }
        }

        private async Task<TResponse> PerformRequest<TResponse>(string node, IDictionary<string, object> request, FileStream writeStream = null)
            where TResponse : BaseResponse, new()
        {
            request["cmd"] = node;

            MultipartFormDataContent requestBody = MakeRequestBody(node, request);

            var client = GetHttpClient();
            var response = await SendRequestAsync(client, node, requestBody, request);
            HttpResponseStream fileStream = null;
            var disposeResponse = true;
            try
            {
                string resultString;
                if (string.Equals(response.Content.Headers.ContentType?.MediaType, 
                 "application/octet-stream", 
                 StringComparison.OrdinalIgnoreCase)){
                    Log(LogSeverity.Info, $"Response code: {(int)response.StatusCode}");
                    var networkStream = await response.Content.ReadAsStreamAsync();
                    fileStream = new HttpResponseStream(networkStream, response);
                    disposeResponse = false;

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
                    if(fileStream != null){
                        dynamic dynamicResult = result;
                        dynamicResult.FileContent = fileStream;
                        fileStream = null;
                        return dynamicResult;
                    }
                    return result;
                } 
                
                Log(LogSeverity.Error, result.GetError().Msg);
                throw new VoximplantException(result.GetError().Msg, result.GetError().Code);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
                else if (disposeResponse)
                {
                    response.Dispose();
                }
            }
        }

        /// <summary>
        /// Stream returned as <c>FileContent</c>. Disposing it also disposes the
        /// <see cref="HttpResponseMessage"/> so the connection returns to the pool.
        /// </summary>
        private sealed class HttpResponseStream : Stream
        {
            private readonly Stream _inner;
            private readonly HttpResponseMessage _response;
            private bool _disposed;

            public HttpResponseStream(Stream inner, HttpResponseMessage response)
            {
                _inner = inner;
                _response = response;
            }

            public override bool CanRead => _inner.CanRead;
            public override bool CanSeek => _inner.CanSeek;
            public override bool CanWrite => _inner.CanWrite;
            public override long Length => _inner.Length;
            public override bool CanTimeout => _inner.CanTimeout;

            public override long Position
            {
                get => _inner.Position;
                set => _inner.Position = value;
            }

            public override int ReadTimeout
            {
                get => _inner.ReadTimeout;
                set => _inner.ReadTimeout = value;
            }

            public override int WriteTimeout
            {
                get => _inner.WriteTimeout;
                set => _inner.WriteTimeout = value;
            }

            public override void Flush()
            {
                _inner.Flush();
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                return _inner.Read(buffer, offset, count);
            }

            public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                return _inner.ReadAsync(buffer, offset, count, cancellationToken);
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                return _inner.Seek(offset, origin);
            }

            public override void SetLength(long value)
            {
                _inner.SetLength(value);
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                _inner.Write(buffer, offset, count);
            }

            protected override void Dispose(bool disposing)
            {
                if (disposing && !_disposed)
                {
                    _disposed = true;
                    _inner.Dispose();
                    _response.Dispose();
                }

                base.Dispose(disposing);
            }
        }
    }
}
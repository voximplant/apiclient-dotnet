using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Org.BouncyCastle.Security;
using Voximplant.API.Request;
using Voximplant.API.Response;

namespace Voximplant.API
{
    public partial class VoximplantAPI
    {
        private readonly ClientConfiguration _configuration;
        private readonly Credentials _credentials;

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
            _configuration = configuration;
            _credentials = Credentials.Load(_configuration.KeyFile);
        }

        private string GetAuthorizationHeader()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var credentials = new SigningCredentials(_credentials.PrivateKey, SecurityAlgorithms.RsaSha256);

            var token = tokenHandler.CreateJwtSecurityToken(issuer: _credentials.AccountId.ToString(),
                signingCredentials: credentials);

            return $"Bearer {tokenHandler.WriteToken(token)}";
        }

        private Uri RequestUri(string action)
        {
            return new Uri(
                $"http{(_configuration.UseHTTPS ? "s" : "")}://{_configuration.APIHost}/platform_api/{action}");
        }

        private TResponse PerformRequest<TResponse, TRequest>(string node, TRequest request)
            where TRequest : BaseRequest
            where TResponse : BaseResponse
        {
            using (var client = new HttpClient())
            {
                request.SetAccountId(_credentials.AccountId);
                var requestBody = new FormUrlEncodedContent(request);

                client.DefaultRequestHeaders.Add("Authorization", GetAuthorizationHeader());

                var response = client.PostAsync(RequestUri(node), requestBody).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;

                var result = JsonConvert.DeserializeObject<TResponse>(responseString, new JsonSerializerSettings
                {
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                    TraceWriter = _configuration.TraceWriter,
                });

                if (result.HasError())
                {
                    throw new APIException(result.GetError().Msg, result.GetError().Code);
                }

                return result;
            }
        }
    }
}
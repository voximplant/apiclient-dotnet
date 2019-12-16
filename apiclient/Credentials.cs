using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace Voximplant.API
{
    public class Credentials
    {
        [JsonProperty("account_email")]
        public string Email { get; private set; }

        [JsonProperty("account_id")]
        public long AccountId { get; private set; }

        [JsonProperty("key_id")]
        public string KeyId { get; private set; }

        [JsonProperty("private_key")]
        private readonly string _privateKey = null;

        public RsaSecurityKey PrivateKey { get; private set; } 

        private Credentials()
        {
        }

        public static Credentials Load(string filename)
        {
            if (string.IsNullOrEmpty(filename) || !File.Exists(filename))
            {
                throw new ClientException($"Key file not found: '{filename}'");
            }

            var credentials = JsonConvert.DeserializeObject<Credentials>(File.ReadAllText(filename));
            credentials.PrivateKey = new RsaSecurityKey(credentials.GetRSAParameters()) {KeyId = credentials.KeyId};
            return credentials;
        }

        private RSAParameters GetRSAParameters()
        {
            var byteArray = Encoding.ASCII.GetBytes(_privateKey);
            using (var stream = new MemoryStream(byteArray))
            {
                using (var reader = new StreamReader(stream))
                {
                    var pemReader = new PemReader(reader);
                    var privateKey = pemReader.ReadObject() as RsaPrivateCrtKeyParameters;
                    return DotNetUtilities.ToRSAParameters(privateKey);
                }
            }
        }
    }
}
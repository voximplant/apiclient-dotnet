using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetPushCredentialRequest : BaseRequest
    {
        /// <summary>
        /// The push credentials id.
        /// </summary>
        [JsonProperty("push_credential_id")]
        public long? PushCredentialId { get; set; }

        /// <summary>
        /// Public and private keys in PKCS12 format.
        /// </summary>
        [JsonProperty("cert_content")]
        public string CertContent { get; set; }

        /// <summary>
        /// The secret password for private key.
        /// </summary>
        [JsonProperty("cert_password")]
        public string CertPassword { get; set; }

        /// <summary>
        /// Set true for use this certificate in apple's sandbox environment
        /// </summary>
        [JsonProperty("is_dev_mode")]
        public bool? IsDevMode { get; set; }

        /// <summary>
        /// The sender id, provided by Google.
        /// </summary>
        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        /// <summary>
        /// The server key, provided by Google.
        /// </summary>
        [JsonProperty("server_key")]
        public string ServerKey { get; set; }

    }
}
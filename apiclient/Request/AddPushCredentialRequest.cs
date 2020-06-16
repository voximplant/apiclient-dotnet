using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddPushCredentialRequest : BaseRequest
    {
        /// <summary>
        /// The push provider name. The possible values are: APPLE, APPLE_VOIP,
        /// GOOGLE.
        /// </summary>
        [JsonProperty("push_provider_name")]
        public string PushProviderName { get; set; }

        /// <summary>
        /// The push provider id.
        /// </summary>
        [JsonProperty("push_provider_id")]
        public long? PushProviderId { get; set; }

        /// <summary>
        /// The bundle of Android/iOS application.
        /// </summary>
        [JsonProperty("credential_bundle")]
        public string CredentialBundle { get; set; }

        /// <summary>
        /// Public and private keys in PKCS12 format.
        /// </summary>
        [JsonProperty("cert_content")]
        public string CertContent { get; set; }

        /// <summary>
        /// The parameter is required, when set 'cert_content' as POST body.
        /// </summary>
        [JsonProperty("cert_file_name")]
        public string CertFileName { get; set; }

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
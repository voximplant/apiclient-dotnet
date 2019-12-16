using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetPushCredentialRequest : BaseRequest
    {
        /// <summary>
        /// The push credentials id.
        /// </summary>
        [JsonProperty("push_credential_id")]
        public long? PushCredentialId { get; set; }

        /// <summary>
        /// The push provider name. Available values: APPLE, APPLE_VOIP, GOOGLE.
        /// </summary>
        [JsonProperty("push_provider_name")]
        public string PushProviderName { get; set; }

        /// <summary>
        /// The push provider id.
        /// </summary>
        [JsonProperty("push_provider_id")]
        public long? PushProviderId { get; set; }

        /// <summary>
        /// The name of bound application.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The id of bound application.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// Set true to get the user's certificate.
        /// </summary>
        [JsonProperty("with_cert")]
        public bool? WithCert { get; set; }

        /// <summary>
        /// Set true to get the certificate's password.
        /// </summary>
        [JsonProperty("with_secret_info")]
        public bool? WithSecretInfo { get; set; }

    }
}
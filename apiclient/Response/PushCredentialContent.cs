using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The push credentials list item info.
    /// </summary>
    public class PushCredentialContent
    {
        /// <summary>
        /// The file name. Credentials for APPLE push.
        /// </summary>
        [JsonProperty("cert_file_name")]
        public string CertFileName { get; private set; }

        /// <summary>
        /// The password for private key. Credentials for APPLE push.
        /// </summary>
        [JsonProperty("cert_password")]
        public string CertPassword { get; private set; }

        /// <summary>
        /// The certificate content in BASE64. Credentials for APPLE push.
        /// </summary>
        [JsonProperty("cert_content")]
        public string CertContent { get; private set; }

        /// <summary>
        /// The use in a Apple sandbox environment. Credentials for APPLE push.
        /// </summary>
        [JsonProperty("is_dev_mode")]
        public bool? IsDevMode { get; private set; }

        /// <summary>
        /// The sender id provided by Google. Credentials for GOOGLE push.
        /// </summary>
        [JsonProperty("sender_id")]
        public string SenderId { get; private set; }

        /// <summary>
        /// The server key provided by Google. Credentials for GOOGLE push.
        /// </summary>
        [JsonProperty("server_key")]
        public string ServerKey { get; private set; }

    }
}
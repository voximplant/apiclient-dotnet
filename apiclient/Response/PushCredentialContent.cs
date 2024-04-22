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
        /// The file name. Credentials for APPLE push
        /// </summary>
        [JsonProperty("cert_file_name")]
        public string CertFileName { get; private set; }

        /// <summary>
        /// The certificate content in BASE64. Credentials for APPLE push
        /// </summary>
        [JsonProperty("cert_content")]
        public string CertContent { get; private set; }

        /// <summary>
        /// Whether to use in a Apple sandbox environment. Credentials for APPLE push
        /// </summary>
        [JsonProperty("is_dev_mode")]
        public bool IsDevMode { get; private set; }

        /// <summary>
        /// The sender id provided by Google. Credentials for GOOGLE push
        /// </summary>
        [JsonProperty("sender_id")]
        public string SenderId { get; private set; }

        /// <summary>
        /// The client id, provided by Huawei. Credentials for HUAWEI push
        /// </summary>
        [JsonProperty("huawei_client_id")]
        public string HuaweiClientId { get; private set; }

        /// <summary>
        /// The application id, provided by Huawei. Credentials for HUAWEI push
        /// </summary>
        [JsonProperty("huawei_application_id")]
        public string HuaweiApplicationId { get; private set; }

    }
}
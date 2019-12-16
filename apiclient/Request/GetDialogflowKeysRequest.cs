using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetDialogflowKeysRequest : BaseRequest
    {
        /// <summary>
        /// The Dialogflow key's ID.
        /// </summary>
        [JsonProperty("dialogflow_key_id")]
        public long? DialogflowKeyId { get; set; }

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
        /// Set true to get the json web key.
        /// </summary>
        [JsonProperty("with_secret_info")]
        public bool? WithSecretInfo { get; set; }

    }
}
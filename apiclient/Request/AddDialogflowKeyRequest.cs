using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddDialogflowKeyRequest : BaseRequest
    {
        /// <summary>
        /// The application ID.
        /// </summary>
        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The application name. Can be used instead of <b>application_id</b>.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Dialogflow credentials, provided by JWK (Json web key).
        /// </summary>
        [JsonProperty("json_credentials")]
        public string JsonCredentials { get; set; }

        /// <summary>
        /// The Dialogflow keys's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

    }
}
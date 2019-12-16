using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetDialogflowKeyRequest : BaseRequest
    {
        /// <summary>
        /// The Dialogflow key's ID.
        /// </summary>
        [JsonProperty("dialogflow_key_id")]
        public long? DialogflowKeyId { get; set; }

        /// <summary>
        /// The Dialogflow keys's description. To clear previously set
        /// description leave the parameter blank or put whitespaces only.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

    }
}
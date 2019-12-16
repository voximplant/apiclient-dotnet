using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelDialogflowKeyRequest : BaseRequest
    {
        /// <summary>
        /// The Dialogflow key's ID.
        /// </summary>
        [JsonProperty("dialogflow_key_id")]
        public long? DialogflowKeyId { get; set; }

    }
}
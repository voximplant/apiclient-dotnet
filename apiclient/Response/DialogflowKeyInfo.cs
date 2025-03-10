using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The Dialogflow keys list info.
    /// </summary>
    public class DialogflowKeyInfo
    {
        /// <summary>
        /// The Dialogflow key's id
        /// </summary>
        [JsonProperty("dialogflow_key_id")]
        public long DialogflowKeyId { get; private set; }

        /// <summary>
        /// The key's content
        /// </summary>
        [JsonProperty("content")]
        public DialogflowKey Content { get; private set; }

        /// <summary>
        /// Bound applications
        /// </summary>
        [JsonProperty("applications")]
        public ApplicationInfoType[] Applications { get; private set; }

    }
}
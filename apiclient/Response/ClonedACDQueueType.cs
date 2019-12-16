using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The cloned ACD queue info.
    /// </summary>
    public class ClonedACDQueueType
    {
        /// <summary>
        /// The ACD queue ID.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public long? AcdQueueId { get; private set; }

        /// <summary>
        /// The ACD queue name.
        /// </summary>
        [JsonProperty("acd_queue_name")]
        public string AcdQueueName { get; private set; }

    }
}
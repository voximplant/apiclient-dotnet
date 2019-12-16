using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The 'acd_queues' element of the [GetUsers] function result.
    /// </summary>
    public class ACDQueueOperatorInfoType
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

        /// <summary>
        /// The user bound with the ACD queue in the manual mode if false.
        /// </summary>
        [JsonProperty("auto_link")]
        public bool? AutoLink { get; private set; }

    }
}
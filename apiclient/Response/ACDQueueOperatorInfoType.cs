using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The 'acd_queues' element of the [GetUsers] function result.
    /// </summary>
    public class ACDQueueOperatorInfoType
    {
        /// <summary>
        /// The ACD queue ID
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public long AcdQueueId { get; private set; }

        /// <summary>
        /// The ACD queue name
        /// </summary>
        [JsonProperty("acd_queue_name")]
        public string AcdQueueName { get; private set; }

        /// <summary>
        /// Whether the user is bound to the ACD queue in manual mode if false
        /// </summary>
        [JsonProperty("auto_link")]
        public bool AutoLink { get; private set; }

    }
}
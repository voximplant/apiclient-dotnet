using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelQueueRequest : BaseRequest
    {
        /// <summary>
        /// The ACD queue ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public Argument<long> AcdQueueId { get; set; }

        /// <summary>
        /// The ACD queue name that can be used instead of <b>acd_queue_id</b>.
        /// The ACD queue name list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("acd_queue_name")]
        public Argument<string> AcdQueueName { get; set; }

    }
}
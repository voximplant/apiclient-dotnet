using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetACDStateRequest : BaseRequest
    {
        /// <summary>
        /// The ACD queue ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public Argument<long> AcdQueueId { get; set; }

    }
}
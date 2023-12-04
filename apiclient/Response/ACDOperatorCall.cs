using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The ACD operator call type.
    /// </summary>
    public class ACDOperatorCall
    {
        /// <summary>
        /// The ACD session history ID of the request
        /// </summary>
        [JsonProperty("acd_session_history_id")]
        public long AcdSessionHistoryId { get; private set; }

        /// <summary>
        /// The internal ACD session history ID
        /// </summary>
        [JsonProperty("acd_request_id")]
        public string AcdRequestId { get; private set; }

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
        /// The client callerid
        /// </summary>
        [JsonProperty("callerid")]
        public string Callerid { get; private set; }

        /// <summary>
        /// The begin time of the request in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("begin_time")]
        public DateTime BeginTime { get; private set; }

        /// <summary>
        /// The submission time of the request in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("submitted")]
        public DateTime? Submitted { get; private set; }

    }
}
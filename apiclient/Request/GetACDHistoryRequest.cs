using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetACDHistoryRequest : BaseRequest
    {
        /// <summary>
        /// The UTC 'from' date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("from_date")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// The UTC 'to' date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("to_date")]
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// The ACD session history ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("acd_session_history_id")]
        public Argument<long> AcdSessionHistoryId { get; set; }

        /// <summary>
        /// The ACD request ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("acd_request_id")]
        public Argument<string> AcdRequestId { get; set; }

        /// <summary>
        /// The ACD queue ID list to filter separated by the ';' symbol.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public Argument<long> AcdQueueId { get; set; }

        /// <summary>
        /// The user ID list to filter separated by the ';' symbol.
        /// </summary>
        [JsonProperty("user_id")]
        public Argument<long> UserId { get; set; }

        /// <summary>
        /// Set true to get the calls terminated by the operator.
        /// </summary>
        [JsonProperty("operator_hangup")]
        public bool? OperatorHangup { get; set; }

        /// <summary>
        /// The unserviced calls by the operator.
        /// </summary>
        [JsonProperty("unserviced")]
        public bool? Unserviced { get; set; }

        /// <summary>
        /// The min waiting time filter.
        /// </summary>
        [JsonProperty("min_waiting_time")]
        public long? MinWaitingTime { get; set; }

        /// <summary>
        /// The rejected calls by the 'max_queue_size', 'max_waiting_time'
        /// threshold.
        /// </summary>
        [JsonProperty("rejected")]
        public bool? Rejected { get; set; }

        /// <summary>
        /// Set true to get the bound events.
        /// </summary>
        [JsonProperty("with_events")]
        public bool? WithEvents { get; set; }

        /// <summary>
        /// Set false to get a CSV file without the column names if the output=csv
        /// </summary>
        [JsonProperty("with_header")]
        public bool? WithHeader { get; set; }

        /// <summary>
        /// Set true to get records in the descent order.
        /// </summary>
        [JsonProperty("desc_order")]
        public bool? DescOrder { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// The output format. The following values available: json, csv
        /// </summary>
        [JsonProperty("output")]
        public string Output { get; set; }

    }
}
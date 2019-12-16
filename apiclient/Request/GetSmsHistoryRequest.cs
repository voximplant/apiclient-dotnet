using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetSmsHistoryRequest : BaseRequest
    {
        /// <summary>
        /// The source phone number.
        /// </summary>
        [JsonProperty("source_number")]
        public string SourceNumber { get; set; }

        /// <summary>
        /// The destination phone number.
        /// </summary>
        [JsonProperty("destination_number")]
        public string DestinationNumber { get; set; }

        /// <summary>
        /// Sent or received SMS. Possible values: 'IN', 'OUT', 'in, 'out'. Leave
        /// blank to get both incoming and outgoing messages.
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Maximum number of resulting rows fetched. Must be not more than 1000.
        /// If left blank, then the default value of 1000 will be used.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// Date from which to perform search. Format is 'yyyy-MM-dd HH:mm:ss'.
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("from_date")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// Date until which to perform search. Format is 'yyyy-MM-dd HH:mm:ss'.
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("to_date")]
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// The output format. The following values available: json, csv.
        /// </summary>
        [JsonProperty("output")]
        public string Output { get; set; }

    }
}
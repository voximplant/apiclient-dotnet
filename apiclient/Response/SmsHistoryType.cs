using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetSmsHistory] function result.
    /// </summary>
    public class SmsHistoryType
    {
        /// <summary>
        /// Id of the message.
        /// </summary>
        [JsonProperty("sms_id")]
        public long? SmsId { get; private set; }

        /// <summary>
        /// Number being called from.
        /// </summary>
        [JsonProperty("source_number")]
        public long? SourceNumber { get; private set; }

        /// <summary>
        /// Number being called to.
        /// </summary>
        [JsonProperty("destination_number")]
        public long? DestinationNumber { get; private set; }

        /// <summary>
        /// Incoming or outgoing message.
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; private set; }

        /// <summary>
        /// Number of fragments the initial message was divided into.
        /// </summary>
        [JsonProperty("fragments")]
        public long? Fragments { get; private set; }

        /// <summary>
        /// Cost of the message.
        /// </summary>
        [JsonProperty("cost")]
        public decimal? Cost { get; private set; }

        /// <summary>
        /// Status of the message. 1 - Success, 2 - Error.
        /// </summary>
        [JsonProperty("status_id")]
        public long? StatusId { get; private set; }

        /// <summary>
        /// Error message if any.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Date of message processing. The format is yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("processed_date")]
        public DateTime? ProcessedDate { get; private set; }

        /// <summary>
        /// Id of the transaction for this message.
        /// </summary>
        [JsonProperty("transaction_id")]
        public long? TransactionId { get; private set; }

    }
}
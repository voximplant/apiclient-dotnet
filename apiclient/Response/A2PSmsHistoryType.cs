using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [A2PGetSmsHistory] function result.
    /// </summary>
    public class A2PSmsHistoryType
    {
        /// <summary>
        /// Message ID
        /// </summary>
        [JsonProperty("message_id")]
        public long MessageId { get; private set; }

        /// <summary>
        /// SMS source number
        /// </summary>
        [JsonProperty("source_number")]
        public long SourceNumber { get; private set; }

        /// <summary>
        /// SMS destination number
        /// </summary>
        [JsonProperty("destination_number")]
        public long DestinationNumber { get; private set; }

        /// <summary>
        /// Number of fragments the initial message is divided into
        /// </summary>
        [JsonProperty("fragments")]
        public long Fragments { get; private set; }

        /// <summary>
        /// The message cost
        /// </summary>
        [JsonProperty("cost")]
        public decimal Cost { get; private set; }

        /// <summary>
        /// The message status. 1 - Success, 2 - Error
        /// </summary>
        [JsonProperty("status_id")]
        public string StatusId { get; private set; }

        /// <summary>
        /// Error message (if any)
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Date of message processing. The format is yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("processing_date")]
        public DateTime ProcessingDate { get; private set; }

        /// <summary>
        /// The transaction ID for this message
        /// </summary>
        [JsonProperty("transaction_id")]
        public long TransactionId { get; private set; }

        /// <summary>
        /// Delivery status: QUEUED, DISPATCHED, ABORTED, REJECTED, DELIVERED, FAILED, EXPIRED, UNKNOWN
        /// </summary>
        [JsonProperty("delivery_status")]
        public string DeliveryStatus { get; private set; }

        /// <summary>
        /// Stored message text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; private set; }

    }
}
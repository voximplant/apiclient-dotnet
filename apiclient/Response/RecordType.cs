using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The record info.
    /// </summary>
    public class RecordType
    {
        /// <summary>
        /// The record ID.
        /// </summary>
        [JsonProperty("record_id")]
        public long? RecordId { get; private set; }

        /// <summary>
        /// The record name.
        /// </summary>
        [JsonProperty("record_name")]
        public string RecordName { get; private set; }

        /// <summary>
        /// The record cost.
        /// </summary>
        [JsonProperty("cost")]
        public decimal? Cost { get; private set; }

        /// <summary>
        /// The start recording time in the selected timezone in 24-h format:
        /// YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("start_time")]
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// The call duration in seconds.
        /// </summary>
        [JsonProperty("duration")]
        public long? Duration { get; private set; }

        /// <summary>
        /// The record URL.
        /// </summary>
        [JsonProperty("record_url")]
        public string RecordUrl { get; private set; }

        /// <summary>
        /// The transaction ID.
        /// </summary>
        [JsonProperty("transaction_id")]
        public long? TransactionId { get; private set; }

        /// <summary>
        /// The file size.
        /// </summary>
        [JsonProperty("file_size")]
        public decimal? FileSize { get; private set; }

        /// <summary>
        /// The url of transcription.
        /// </summary>
        [JsonProperty("transcription_url")]
        public string TranscriptionUrl { get; private set; }

        /// <summary>
        /// The status of transcription. The possible values are: Not required,
        /// In progress, Complete
        /// </summary>
        [JsonProperty("transcription_status")]
        public string TranscriptionStatus { get; private set; }

    }
}
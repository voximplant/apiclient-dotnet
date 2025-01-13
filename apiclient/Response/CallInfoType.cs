using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The call info.
    /// </summary>
    public class CallInfoType
    {
        /// <summary>
        /// The call history ID
        /// </summary>
        [JsonProperty("call_id")]
        public long CallId { get; private set; }

        /// <summary>
        /// The start time in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("start_time")]
        public DateTime StartTime { get; private set; }

        /// <summary>
        /// The call duration in seconds
        /// </summary>
        [JsonProperty("duration")]
        public long? Duration { get; private set; }

        /// <summary>
        /// The local number on the platform side
        /// </summary>
        [JsonProperty("local_number")]
        public string LocalNumber { get; private set; }

        /// <summary>
        /// The remote number on the client side
        /// </summary>
        [JsonProperty("remote_number")]
        public string RemoteNumber { get; private set; }

        /// <summary>
        /// The type of the remote number, such as PSTN, mobile, user or sip address
        /// </summary>
        [JsonProperty("remote_number_type")]
        public string RemoteNumberType { get; private set; }

        /// <summary>
        /// Whether the call is incoming
        /// </summary>
        [JsonProperty("incoming")]
        public bool Incoming { get; private set; }

        /// <summary>
        /// Whether the call is successful
        /// </summary>
        [JsonProperty("successful")]
        public bool Successful { get; private set; }

        /// <summary>
        /// The transaction ID
        /// </summary>
        [JsonProperty("transaction_id")]
        public long TransactionId { get; private set; }

        /// <summary>
        /// The record URL
        /// </summary>
        [JsonProperty("record_url")]
        public string RecordUrl { get; private set; }

        /// <summary>
        /// The media server IP address
        /// </summary>
        [JsonProperty("media_server_address")]
        public string MediaServerAddress { get; private set; }

        /// <summary>
        /// The call cost
        /// </summary>
        [JsonProperty("cost")]
        public decimal? Cost { get; private set; }

        /// <summary>
        /// The custom data passed to the JS session
        /// </summary>
        [JsonProperty("custom_data")]
        public string CustomData { get; private set; }

        /// <summary>
        /// End reason code and description
        /// </summary>
        [JsonProperty("end_reason")]
        public object EndReason { get; private set; }

    }
}
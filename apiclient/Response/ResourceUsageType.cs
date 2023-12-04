using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The resource usage info.
    /// </summary>
    public class ResourceUsageType
    {
        /// <summary>
        /// The resource usage ID
        /// </summary>
        [JsonProperty("resource_usage_id")]
        public long ResourceUsageId { get; private set; }

        /// <summary>
        /// The resource type. The possible values are CALLSESSION, VIDEOCALL, VIDEORECORD, VOICEMAILDETECTION, YANDEXASR, ASR, TRANSCRIPTION, TTS_TEXT_GOOGLE, TTS_YANDEX, AUDIOHDCONFERENCE
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// The resource cost
        /// </summary>
        [JsonProperty("cost")]
        public decimal? Cost { get; private set; }

        /// <summary>
        /// The description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The start resource using time in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("used_at")]
        public DateTime UsedAt { get; private set; }

        /// <summary>
        /// The transaction ID
        /// </summary>
        [JsonProperty("transaction_id")]
        public long TransactionId { get; private set; }

        /// <summary>
        /// The resource quantity
        /// </summary>
        [JsonProperty("resource_quantity")]
        public long? ResourceQuantity { get; private set; }

        /// <summary>
        /// The resource unit
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// The reference to call
        /// </summary>
        [JsonProperty("ref_call_id")]
        public long? RefCallId { get; private set; }

    }
}
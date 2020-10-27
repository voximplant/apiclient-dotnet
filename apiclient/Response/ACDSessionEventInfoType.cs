using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The ACD session event info.
    /// </summary>
    public class ACDSessionEventInfoType
    {
        /// <summary>
        /// The ACD session event ID.
        /// </summary>
        [JsonProperty("acd_session_event_id")]
        public long AcdSessionEventId { get; private set; }

        /// <summary>
        /// The UTC start date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; private set; }

        /// <summary>
        /// The event type name.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; private set; }

        /// <summary>
        /// The custom data.
        /// </summary>
        [JsonProperty("custom_data")]
        public string CustomData { get; private set; }

    }
}
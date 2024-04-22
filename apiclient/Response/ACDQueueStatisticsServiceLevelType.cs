using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Individual service level description used in the [ACDQueueStatisticsType].
    /// </summary>
    public class ACDQueueStatisticsServiceLevelType
    {
        /// <summary>
        /// Maximum time, is seconds, user is waiting operator for a given service level
        /// </summary>
        [JsonProperty("acceptable_waiting_time")]
        public long AcceptableWaitingTime { get; private set; }

        /// <summary>
        /// Number of calls for a given service level
        /// </summary>
        [JsonProperty("call_count")]
        public long CallCount { get; private set; }

        /// <summary>
        /// Percentage of calls for a given service level, from 0 (non-inclusive) up to 1 (all calls)
        /// </summary>
        [JsonProperty("service_level")]
        public long ServiceLevel { get; private set; }

    }
}
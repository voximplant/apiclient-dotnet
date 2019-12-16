using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Individual statistics item in the [ACDQueueStatisticsType] record.
    /// </summary>
    public class ACDStatisticsCalls
    {
        /// <summary>
        /// Absolute number of calls.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; private set; }

        /// <summary>
        /// Percentage of answered/rejected/unanswered calls, is counted against
        /// total number of calls.
        /// </summary>
        [JsonProperty("percent")]
        public long? Percent { get; private set; }

    }
}
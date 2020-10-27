using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Individual statistics item in the [ACDOperatorStatisticsType], [ACDQueueStatisticsType], and [ACDOperatorStatusStatisticsDetail] records.
    /// </summary>
    public class ACDStatisticsItemType
    {
        /// <summary>
        /// Minimum value over the aggregated interval, in seconds
        /// </summary>
        [JsonProperty("min")]
        public long Min { get; private set; }

        /// <summary>
        /// Average value over the aggregated interval, in seconds
        /// </summary>
        [JsonProperty("avg")]
        public long Avg { get; private set; }

        /// <summary>
        /// Maximum value over the aggregated interval, in seconds
        /// </summary>
        [JsonProperty("max")]
        public long Max { get; private set; }

        /// <summary>
        /// Samples count over the aggregated interval
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

        /// <summary>
        /// Sum of all samples over the aggregated interval, in seconds
        /// </summary>
        [JsonProperty("sum")]
        public long Sum { get; private set; }

    }
}
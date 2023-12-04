using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [SmartQueueMetricsGroups] details.
    /// </summary>
    public class SmartQueueMetricsGroupsValues
    {
        /// <summary>
        /// The start of the period
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("from_date")]
        public DateTime FromDate { get; private set; }

        /// <summary>
        /// The end of the period
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("to_date")]
        public DateTime ToDate { get; private set; }

        /// <summary>
        /// The report value
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetSmartQueueRealtimeMetrics] function result.
    /// </summary>
    public class SmartQueueMetricsResult
    {
        /// <summary>
        /// The report type(s).
        /// </summary>
        [JsonProperty("report_type")]
        public string ReportType { get; private set; }

        /// <summary>
        /// Grouping by **agent** or **queue**.
        /// </summary>
        [JsonProperty("groups")]
        public SmartQueueMetricsGroups[] Groups { get; private set; }

    }
}
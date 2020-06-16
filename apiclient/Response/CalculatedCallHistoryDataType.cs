using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [HistoryReportType] calculated_data object if the
    /// [HistoryReportType] history_type parameter is set to 'calls'.
    /// </summary>
    public class CalculatedCallHistoryDataType
    {
        /// <summary>
        /// The session count in the report.
        /// </summary>
        [JsonProperty("session_count")]
        public long? SessionCount { get; private set; }

        /// <summary>
        /// The total found filtered session count.
        /// </summary>
        [JsonProperty("total_session_count")]
        public long? TotalSessionCount { get; private set; }

        /// <summary>
        /// The selected timezone.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; private set; }

    }
}
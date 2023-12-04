using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetCallHistoryResponse : BaseResponse
    {
        /// <summary>
        /// The CallSessionInfoType records in sync mode or 1 in async mode
        /// </summary>
        [JsonProperty("result")]
        public CallSessionInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found call session count (sync mode)
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned call session count (sync mode)
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

        /// <summary>
        /// The used timezone
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; private set; }

        /// <summary>
        /// The history report ID (async mode)
        /// </summary>
        [JsonProperty("history_report_id")]
        public long HistoryReportId { get; private set; }

    }
}
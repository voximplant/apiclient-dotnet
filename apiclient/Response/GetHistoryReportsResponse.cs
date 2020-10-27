using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetHistoryReportsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public HistoryReportType[] Result { get; private set; }

        /// <summary>
        /// The total found reports count.
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned reports count.
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
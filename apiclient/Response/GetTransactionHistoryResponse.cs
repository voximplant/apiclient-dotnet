using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetTransactionHistoryResponse : BaseResponse
    {

        [JsonProperty("result")]
        public TransactionInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found transaction count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The used timezone. 'Etc/GMT' for example
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; private set; }

        /// <summary>
        /// The returned transaction count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

        /// <summary>
        /// The history report ID (async mode)
        /// </summary>
        [JsonProperty("history_report_id")]
        public long HistoryReportId { get; private set; }

    }
}
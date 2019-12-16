using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetTransactionHistoryResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<TransactionInfoType> Result { get; private set; }

        /// <summary>
        /// The committed balance on the date equals <b>from_date</b> value. The
        /// parameter value is the number rounded to 4 decimal places and
        /// displays in the currency specified for the account.
        /// </summary>
        [JsonProperty("end_balance")]
        public decimal? EndBalance { get; private set; }

        /// <summary>
        /// The total found transaction count.
        /// </summary>
        [JsonProperty("total_count")]
        public long? TotalCount { get; private set; }

        /// <summary>
        /// The used timezone. 'Etc/GMT' for example.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; private set; }

        /// <summary>
        /// The returned transaction count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; private set; }

        /// <summary>
        /// The committed balance on the date equals <b>to_date</b> value. The
        /// parameter value is the number rounded to 4 decimal places and
        /// displays in the currency specified for the account.
        /// </summary>
        [JsonProperty("start_balance")]
        public decimal? StartBalance { get; private set; }

        /// <summary>
        /// The history report ID (async mode).
        /// </summary>
        [JsonProperty("history_report_id")]
        public long? HistoryReportId { get; private set; }

    }
}
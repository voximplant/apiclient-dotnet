using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class TransactionHistoryReportCallback
    {
        /// <summary>
        /// The history report ID.
        /// </summary>
        [JsonProperty("history_report_id")]
        public long HistoryReportId { get; private set; }

        /// <summary>
        /// Success flag.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; private set; }

        /// <summary>
        /// The UTC order date in format: YYYY-MM-DD HH::mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("order_date")]
        public DateTime OrderDate { get; private set; }

    }
}
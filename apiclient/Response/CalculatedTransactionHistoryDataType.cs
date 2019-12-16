using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [HistoryReportType] calculated_data object if the
    /// [HistoryReportType] history_type parameter is set to 'transactions'
    /// </summary>
    public class CalculatedTransactionHistoryDataType
    {
        /// <summary>
        /// The transaction count in the report.
        /// </summary>
        [JsonProperty("transaction_count")]
        public long? TransactionCount { get; private set; }

        /// <summary>
        /// The total found filtered transaction count.
        /// </summary>
        [JsonProperty("total_transaction_count")]
        public long? TotalTransactionCount { get; private set; }

        /// <summary>
        /// The start account/user balance with currency. Example: 2.3 USD
        /// </summary>
        [JsonProperty("start_balance")]
        public string StartBalance { get; private set; }

        /// <summary>
        /// The end account/user balance with currency. Example: 12.5 RUR
        /// </summary>
        [JsonProperty("end_balance")]
        public string EndBalance { get; private set; }

        /// <summary>
        /// The account ID.
        /// </summary>
        [JsonProperty("account_id")]
        public long? AccountId { get; private set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; private set; }

        /// <summary>
        /// The user name.
        /// </summary>
        [JsonProperty("user_name")]
        public long? UserName { get; private set; }

        /// <summary>
        /// true if balance&transactions are valid.
        /// </summary>
        [JsonProperty("is_checked")]
        public bool? IsChecked { get; private set; }

        /// <summary>
        /// The selected timezone.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetTransactionHistoryRequest : BaseRequest
    {
        /// <summary>
        /// The from date in the selected timezone in 24-h format: YYYY-MM-DD
        /// HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("from_date")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// The to date in the selected timezone in 24-h format: YYYY-MM-DD
        /// HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("to_date")]
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// The selected timezone or the 'auto' value (will be used the account
        /// location).
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// The transaction ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("transaction_id")]
        public Argument<long> TransactionId { get; set; }

        /// <summary>
        /// The external payment reference to filter.
        /// </summary>
        [JsonProperty("payment_reference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// The transaction type list separated by the ';' symbol. The following
        /// values are possible: periodic_charge, resource_charge,
        /// money_distribution, subscription_charge,
        /// subscription_installation_charge, card_periodic_payment,
        /// card_overrun_payment, card_payment, robokassa_payment, gift,
        /// add_money, subscription_cancel, adjustment, wire_transfer, refund.
        /// </summary>
        [JsonProperty("transaction_type")]
        public Argument<string> TransactionType { get; set; }

        /// <summary>
        /// The user ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("user_id")]
        public Argument<long> UserId { get; set; }

        /// <summary>
        /// The child account ID list separated by the ';' symbol or the 'all'
        /// value.
        /// </summary>
        [JsonProperty("child_account_id")]
        public Argument<long> ChildAccountId { get; set; }

        /// <summary>
        /// Set true to get the children account transactions only.
        /// </summary>
        [JsonProperty("children_transactions_only")]
        public bool? ChildrenTransactionsOnly { get; set; }

        /// <summary>
        /// Set true to get the users' transactions only.
        /// </summary>
        [JsonProperty("users_transactions_only")]
        public bool? UsersTransactionsOnly { get; set; }

        /// <summary>
        /// Set true to get records in the descent order.
        /// </summary>
        [JsonProperty("desc_order")]
        public bool? DescOrder { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// The output format. The following values available: json, csv
        /// </summary>
        [JsonProperty("output")]
        public string Output { get; set; }

        /// <summary>
        /// Set true to get records in the asynchronous mode (for csv output
        /// only). See the [GetHistoryReports], [DownloadHistoryReport]
        /// functions.
        /// </summary>
        [JsonProperty("is_async")]
        public bool? IsAsync { get; set; }

    }
}
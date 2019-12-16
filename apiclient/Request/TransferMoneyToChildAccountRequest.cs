using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class TransferMoneyToChildAccountRequest : BaseRequest
    {
        /// <summary>
        /// The child account ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("child_account_id")]
        public Argument<long> ChildAccountId { get; set; }

        /// <summary>
        /// The money amount, $. The absolute amount value must be equal or
        /// greater than 0.01
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The amount currency (the parent account currency by default).
        /// Examples: RUR, EUR, USD.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Returns error if strict_mode is true and an child account or the
        /// parent account hasn't enough money.
        /// </summary>
        [JsonProperty("strict_mode")]
        public bool? StrictMode { get; set; }

        /// <summary>
        /// The child account transaction description.
        /// </summary>
        [JsonProperty("child_transaction_description")]
        public string ChildTransactionDescription { get; set; }

        /// <summary>
        /// The parent account transaction description. The following macro
        /// available: ${child_account_id}, ${child_account_name}
        /// </summary>
        [JsonProperty("parent_transaction_description")]
        public string ParentTransactionDescription { get; set; }

        /// <summary>
        /// The external payment reference (extra info).
        /// </summary>
        [JsonProperty("payment_reference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// Specify the date in 24-h format: YYYY-MM-DD HH:mm:ss to skip the
        /// duplicate transaction.
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("check_duplicate_reference_from")]
        public DateTime? CheckDuplicateReferenceFrom { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetTransactionHistory] function result item.
    /// </summary>
    public class TransactionInfoType
    {
        /// <summary>
        /// The transaction ID.
        /// </summary>
        [JsonProperty("transaction_id")]
        public long TransactionId { get; private set; }

        /// <summary>
        /// The account ID.
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; private set; }

        /// <summary>
        /// The transaction date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("performed_at")]
        public DateTime PerformedAt { get; private set; }

        /// <summary>
        /// The transaction amount, $.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; private set; }

        /// <summary>
        /// The amount currency (USD, RUR, EUR, ...). 
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// The transaction type. The following values are possible: periodic_charge, resource_charge, money_distribution, subscription_charge, subscription_installation_charge, card_periodic_payment, card_overrun_payment, card_payment, robokassa_payment, gift, add_money, subscription_cancel, adjustment, wire_transfer, refund.
        /// </summary>
        [JsonProperty("transaction_type")]
        public string TransactionType { get; private set; }

        /// <summary>
        /// The transaction description.
        /// </summary>
        [JsonProperty("transaction_description")]
        public string TransactionDescription { get; private set; }

    }
}
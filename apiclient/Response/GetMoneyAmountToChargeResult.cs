using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetMoneyAmountToCharge] function result.
    /// </summary>
    public class GetMoneyAmountToChargeResult
    {
        /// <summary>
        /// The money amount of the subscriptions + plan + negative_balance in
        /// the specified currency.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The 'amount' value minus the positive account balance in the
        /// specified currency.
        /// </summary>
        [JsonProperty("min_amount")]
        public decimal? MinAmount { get; private set; }

        /// <summary>
        /// Exists if bank card payments are allowed. It's the maximum of the
        /// 'amount' in USD and the min_card_payment (10$).
        /// </summary>
        [JsonProperty("bank_card_amount_usd")]
        public decimal? BankCardAmountUsd { get; private set; }

        /// <summary>
        /// Exists if bank card payments are allowed. It's the maximum of the
        /// 'min_amount' in USD and the min_card_payment (10$).
        /// </summary>
        [JsonProperty("min_bank_card_amount_usd")]
        public decimal? MinBankCardAmountUsd { get; private set; }

        /// <summary>
        /// Exists if robokassa payments are allowed. It's the maximum of the
        /// 'min_amount' in RUR and the min_robokassa_payment (500 RUR).
        /// </summary>
        [JsonProperty("robokassa_amount_rub")]
        public decimal? RobokassaAmountRub { get; private set; }

        /// <summary>
        /// Exists if robokassa payments are allowed. It's the maximum of the
        /// 'min_amount' in RUR and the min_robokassa_payment (500 RUR).
        /// </summary>
        [JsonProperty("min_robokassa_amount_rub")]
        public decimal? MinRobokassaAmountRub { get; private set; }

        /// <summary>
        /// The subscriptions to charge.
        /// </summary>
        [JsonProperty("subscriptions")]
        public IReadOnlyList<SubscriptionsToChargeType> Subscriptions { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The payments limits applicable to each payment method. Payments that are beyond limits are declined.
    /// </summary>
    public class BillingLimitsType
    {
        /// <summary>
        /// The Robokassa limits
        /// </summary>
        [JsonProperty("robokassa")]
        public BillingLimitInfoType Robokassa { get; private set; }

        /// <summary>
        /// The bank card limits
        /// </summary>
        [JsonProperty("bank_card")]
        public BankCardBillingLimitInfoType BankCard { get; private set; }

        /// <summary>
        /// The invoice limits
        /// </summary>
        [JsonProperty("invoice")]
        public BillingLimitInfoType Invoice { get; private set; }

    }
}
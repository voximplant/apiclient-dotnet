using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The payment limit info.
    /// </summary>
    public class BankCardBillingLimitInfoType
    {
        /// <summary>
        /// The minimum amount.
        /// </summary>
        [JsonProperty("min_amount")]
        public long MinAmount { get; private set; }

        /// <summary>
        /// The currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

    }
}
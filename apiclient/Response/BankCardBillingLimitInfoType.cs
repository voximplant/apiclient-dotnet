using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The payment limit info.
    /// </summary>
    public class BankCardBillingLimitInfoType
    {
        /// <summary>
        /// The minimum amount
        /// </summary>
        [JsonProperty("min_amount")]
        public decimal MinAmount { get; private set; }

        /// <summary>
        /// The currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

    }
}
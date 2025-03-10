using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when the minimum balance is reached. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class MinBalanceCallback
    {
        /// <summary>
        /// Whether the credit threshold exceeded. The credit threshold = credit_limit - min_balance_to_notify, wherein min_balance_to_notify > 0
        /// </summary>
        [JsonProperty("is_min_credit")]
        public bool IsMinCredit { get; private set; }

        /// <summary>
        /// Whether the callback is repeated
        /// </summary>
        [JsonProperty("is_repeated")]
        public bool IsRepeated { get; private set; }

    }
}
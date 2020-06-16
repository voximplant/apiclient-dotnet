using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetAutochargeConfig] function result.
    /// </summary>
    public class GetAutochargeConfigResultType
    {
        /// <summary>
        /// Is auto charge enabled or not.
        /// </summary>
        [JsonProperty("auto_charge")]
        public bool? AutoCharge { get; private set; }

        /// <summary>
        /// The auto charge threshold.
        /// </summary>
        [JsonProperty("min_balance")]
        public long? MinBalance { get; private set; }

        /// <summary>
        /// The auto top-up amount in the account's currency.
        /// </summary>
        [JsonProperty("card_overrun_value")]
        public string CardOverrunValue { get; private set; }

    }
}
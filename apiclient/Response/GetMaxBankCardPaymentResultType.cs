using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetMaxBankCardPayment] function result.
    /// </summary>
    public class GetMaxBankCardPaymentResultType
    {
        /// <summary>
        /// The maximum payment for the specified card. It's always equal or less than **new_max_payment**
        /// </summary>
        [JsonProperty("max_payment")]
        public long MaxPayment { get; private set; }

        /// <summary>
        /// The maximum payment available for any card. The values depends on payment gateways, previous transactions during the last 24 hours, etc
        /// </summary>
        [JsonProperty("new_max_payment")]
        public long NewMaxPayment { get; private set; }

        /// <summary>
        /// The currency code (USD, RUR, ...)
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

    }
}
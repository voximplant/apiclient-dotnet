using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The bank card error info.
    /// </summary>
    public class BankCardErrorType
    {
        /// <summary>
        /// The error date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("date")]
        public DateTime Date { get; private set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; private set; }

        /// <summary>
        /// The amount in the payment currency.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The payment currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

    }
}
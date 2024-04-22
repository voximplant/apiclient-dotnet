using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetCurrencyRate] function result.
    /// </summary>
    public class ExchangeRates
    {
        /// <summary>
        /// The RUR exchange rate
        /// </summary>
        [JsonProperty("RUR")]
        public decimal? RUR { get; private set; }

        /// <summary>
        /// The KZT exchange rate
        /// </summary>
        [JsonProperty("KZT")]
        public decimal? KZT { get; private set; }

        /// <summary>
        /// The EUR exchange rate
        /// </summary>
        [JsonProperty("EUR")]
        public decimal? EUR { get; private set; }

        /// <summary>
        /// The USD exchange rate. It is always equal to 1
        /// </summary>
        [JsonProperty("USD")]
        public decimal? USD { get; private set; }

    }
}
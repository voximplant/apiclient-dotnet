using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetCurrencyRateResponse : BaseResponse
    {
        /// <summary>
        /// The exchange rates.
        /// </summary>
        [JsonProperty("result")]
        public ExchangeRates Result { get; private set; }

    }
}
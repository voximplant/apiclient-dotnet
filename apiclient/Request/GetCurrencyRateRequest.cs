using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetCurrencyRateRequest : BaseRequest
    {
        /// <summary>
        /// The currency code list separated by the ';' symbol. Examples: RUR,
        /// EUR, USD
        /// </summary>
        [JsonProperty("currency")]
        public Argument<string> Currency { get; set; }

        /// <summary>
        /// The date, format: YYYY-MM-DD
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd")]
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

    }
}
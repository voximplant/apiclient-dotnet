using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetMoneyAmountToChargeRequest : BaseRequest
    {
        /// <summary>
        /// The currency name. Examples: USD, RUR, EUR.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The next charge date, format: YYYY-MM-DD
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd")]
        [JsonProperty("charge_date")]
        public DateTime? ChargeDate { get; set; }

    }
}
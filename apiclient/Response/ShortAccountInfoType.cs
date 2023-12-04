using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The short account info.
    /// </summary>
    public class ShortAccountInfoType
    {
        /// <summary>
        /// The account's ID
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; private set; }

        /// <summary>
        /// Is account blocked by Voximplant admins or not
        /// </summary>
        [JsonProperty("frozen")]
        public bool? Frozen { get; private set; }

        /// <summary>
        /// The account's money
        /// </summary>
        [JsonProperty("balance")]
        public decimal? Balance { get; private set; }

        /// <summary>
        /// The currency code (USD, RUR, EUR, ...)
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

    }
}
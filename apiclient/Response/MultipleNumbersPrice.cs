using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Info about multiple numbers subscription for the child accounts.
    /// </summary>
    public class MultipleNumbersPrice
    {
        /// <summary>
        /// The number of subscriptions which must be purchased simultaneously to
        /// enable a multiple numbers subscription.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; private set; }

        /// <summary>
        /// The subscription price for one number, i.e., the total multiple
        /// numbers subscription price divided by the __count__ value.
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; private set; }

        /// <summary>
        /// The installation price for one number, i.e., the total multiple
        /// numbers installation price divided by the __count__ value.
        /// </summary>
        [JsonProperty("installation_price")]
        public decimal? InstallationPrice { get; private set; }

    }
}
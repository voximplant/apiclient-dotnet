using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Info about multiple numbers subscription for the child accounts.
    /// </summary>
    public class MultipleNumbersPrice
    {
        /// <summary>
        /// The number of subscriptions which must be purchased simultaneously to enable a multiple numbers subscription
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

        /// <summary>
        /// The phone number installation tax reserve
        /// </summary>
        [JsonProperty("installation_tax_reserve")]
        public long InstallationTaxReserve { get; private set; }

        /// <summary>
        /// The phone number tax reserve
        /// </summary>
        [JsonProperty("tax_reserve")]
        public long TaxReserve { get; private set; }

        /// <summary>
        /// Phone number price from the price list
        /// </summary>
        [JsonProperty("local_price")]
        public long? LocalPrice { get; private set; }

        /// <summary>
        /// Phone number installation price from the price list
        /// </summary>
        [JsonProperty("local_installation_price")]
        public long? LocalInstallationPrice { get; private set; }

        /// <summary>
        /// Price list currency
        /// </summary>
        [JsonProperty("local_currency")]
        public string LocalCurrency { get; private set; }

        /// <summary>
        /// Phone number price in the account currency
        /// </summary>
        [JsonProperty("account_price")]
        public long? AccountPrice { get; private set; }

        /// <summary>
        /// Phone number installation price in the account currency
        /// </summary>
        [JsonProperty("account_installation_price")]
        public long? AccountInstallationPrice { get; private set; }

        /// <summary>
        /// Account currency
        /// </summary>
        [JsonProperty("account_currency")]
        public string AccountCurrency { get; private set; }

    }
}
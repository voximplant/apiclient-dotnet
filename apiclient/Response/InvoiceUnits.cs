using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Info about services that were provided.
    /// </summary>
    public class InvoiceUnits
    {
        /// <summary>
        /// The service name.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The service fee (excluding taxes).
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The tax rate in the range of [0 ... 1].
        /// </summary>
        [JsonProperty("vat_rate")]
        public decimal? VatRate { get; private set; }

        /// <summary>
        /// The tax amount.
        /// </summary>
        [JsonProperty("tax_amount")]
        public decimal? TaxAmount { get; private set; }

    }
}
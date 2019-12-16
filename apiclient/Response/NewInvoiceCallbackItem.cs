using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details.
    /// </summary>
    public class NewInvoiceCallbackItem
    {
        /// <summary>
        /// The invoice unique number.
        /// </summary>
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; private set; }

        /// <summary>
        /// The invoice date.
        /// </summary>
        [JsonProperty("invoice_date")]
        public string InvoiceDate { get; private set; }

        /// <summary>
        /// Is it a prepayment?
        /// </summary>
        [JsonProperty("prepayment")]
        public bool? Prepayment { get; private set; }

        /// <summary>
        /// The invoice currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// The invoice's total amount including taxes.
        /// </summary>
        [JsonProperty("total_amount")]
        public decimal? TotalAmount { get; private set; }

        /// <summary>
        /// The total amount of taxes.
        /// </summary>
        [JsonProperty("total_tax_amount")]
        public decimal? TotalTaxAmount { get; private set; }

        /// <summary>
        /// Array with the services that were provided.
        /// </summary>
        [JsonProperty("units")]
        public IReadOnlyList<InvoiceUnits> Units { get; private set; }

    }
}
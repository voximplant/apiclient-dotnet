using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetContractorInvoices] result.
    /// </summary>
    public class ContractorInvoiceType
    {
        /// <summary>
        /// The invoice number
        /// </summary>
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; private set; }

        /// <summary>
        /// The invoice date in format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("invoice_date")]
        public DateTime InvoiceDate { get; private set; }

        /// <summary>
        /// Whether it is post payment
        /// </summary>
        [JsonProperty("is_post_payment")]
        public bool IsPostPayment { get; private set; }

        /// <summary>
        /// The from date in format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("from_date")]
        public DateTime? FromDate { get; private set; }

        /// <summary>
        /// The to date in format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("to_date")]
        public DateTime? ToDate { get; private set; }

        /// <summary>
        /// The total invoice amount (RUR)
        /// </summary>
        [JsonProperty("total_amount")]
        public decimal TotalAmount { get; private set; }

        /// <summary>
        /// The paid amount (RUR)
        /// </summary>
        [JsonProperty("paid_amount")]
        public decimal? PaidAmount { get; private set; }

        /// <summary>
        /// The service list
        /// </summary>
        [JsonProperty("services")]
        public ContractorInvoiceServiceType Services { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class NewInvoiceCallback
    {
        /// <summary>
        /// The invoice info.
        /// </summary>
        [JsonProperty("new_invoice")]
        public NewInvoiceCallbackItem NewInvoice { get; private set; }

    }
}
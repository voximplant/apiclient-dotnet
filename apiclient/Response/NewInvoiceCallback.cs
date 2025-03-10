using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when a new invoice is generated. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class NewInvoiceCallback
    {
        /// <summary>
        /// The invoice info
        /// </summary>
        [JsonProperty("new_invoice")]
        public NewInvoiceCallbackItem NewInvoice { get; private set; }

    }
}
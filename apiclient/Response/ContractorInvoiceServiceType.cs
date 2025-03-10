using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The invoice service info. The [ContractorInvoiceType] field.
    /// </summary>
    public class ContractorInvoiceServiceType
    {
        /// <summary>
        /// The service name
        /// </summary>
        [JsonProperty("service_name")]
        public string ServiceName { get; private set; }

        /// <summary>
        /// The service cost (RUR)
        /// </summary>
        [JsonProperty("service_cost")]
        public decimal ServiceCost { get; private set; }

    }
}
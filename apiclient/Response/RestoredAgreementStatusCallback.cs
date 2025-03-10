using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when an expiration date of the confirmation documents waiting period is changed. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class RestoredAgreementStatusCallback
    {
        /// <summary>
        /// ID of the agreement document which status has been changed
        /// </summary>
        [JsonProperty("document_id")]
        public long DocumentId { get; private set; }

        /// <summary>
        /// The new date of agreement expiration in format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("expiration_date")]
        public DateTime ExpirationDate { get; private set; }

    }
}
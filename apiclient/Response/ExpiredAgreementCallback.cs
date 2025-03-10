using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received for the accounts for which the confirmation documents waiting period has already expired or expires today. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class ExpiredAgreementCallback
    {
        /// <summary>
        /// The list of the expired agreements IDs
        /// </summary>
        [JsonProperty("document_ids")]
        public long[] DocumentIds { get; private set; }

    }
}
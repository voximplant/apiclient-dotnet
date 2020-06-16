using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the
    /// [AccountCallback] structure.
    /// </summary>
    public class ExpiredAgreementCallback
    {
        /// <summary>
        /// The list of the expired agreements IDs.
        /// </summary>
        [JsonProperty("document_ids")]
        public long?[] DocumentIds { get; private set; }

    }
}
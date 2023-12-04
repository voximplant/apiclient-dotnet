using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when a caller ID is about to be expired.
    /// </summary>
    public class ExpiringCallerIDCallback
    {
        /// <summary>
        /// The list of expiring Caller IDs
        /// </summary>
        [JsonProperty("callerids")]
        public string[] Callerids { get; private set; }

        /// <summary>
        /// The Caller IDs expiration date in YYYY-MM-DD format
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("expiration_date")]
        public DateTime ExpirationDate { get; private set; }

    }
}
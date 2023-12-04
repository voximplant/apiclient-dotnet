using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received for the accounts for which the confirmation documents waiting period expires in 20/15/10/5/1 day(s). Received as part of the [AccountCallback] structure.
    /// </summary>
    public class ExpiringAgreementCallback
    {
        /// <summary>
        /// The date of agreement expiration in format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("expiration_date")]
        public DateTime ExpirationDate { get; private set; }

        /// <summary>
        /// The number of days left until an expiration date
        /// </summary>
        [JsonProperty("until_expiration")]
        public long UntilExpiration { get; private set; }

    }
}
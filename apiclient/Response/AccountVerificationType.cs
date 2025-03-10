using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The account verification info. The [AccountVerifications] field.
    /// </summary>
    public class AccountVerificationType
    {
        /// <summary>
        /// The verification name
        /// </summary>
        [JsonProperty("verification_name")]
        public string VerificationName { get; private set; }

        /// <summary>
        /// The account verification status. The following values are possible: REQUIRED, IN_PROGRESS, VERIFIED, NOT_REQUIRED
        /// </summary>
        [JsonProperty("verification_status")]
        public string VerificationStatus { get; private set; }

        /// <summary>
        /// Unverified subscriptions hold until the date in format: YYYY-MM-DD (if the account verification is required). Some subscriptions are detached on that day automatically!
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("unverified_hold_until")]
        public DateTime? UnverifiedHoldUntil { get; private set; }

        /// <summary>
        /// The uploaded documents
        /// </summary>
        [JsonProperty("documents")]
        public AccountVerificationDocument[] Documents { get; private set; }

    }
}
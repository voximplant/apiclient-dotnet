using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetCallerIDs] function result.
    /// </summary>
    public class CallerIDInfoType
    {
        /// <summary>
        /// The callerID id
        /// </summary>
        [JsonProperty("callerid_id")]
        public long CalleridId { get; private set; }

        /// <summary>
        /// The callerID number
        /// </summary>
        [JsonProperty("callerid_number")]
        public string CalleridNumber { get; private set; }

        /// <summary>
        /// Whether active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; private set; }

        /// <summary>
        /// The code entering attempts left for the unverified callerID
        /// </summary>
        [JsonProperty("code_entering_attempts_left")]
        public long? CodeEnteringAttemptsLeft { get; private set; }

        /// <summary>
        /// The verification call attempts left for the unverified callerID
        /// </summary>
        [JsonProperty("verification_call_attempts_left")]
        public long? VerificationCallAttemptsLeft { get; private set; }

        /// <summary>
        /// The verification ending date in format: YYYY-MM-DD (for the verified callerID)
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("verified_until")]
        public DateTime? VerifiedUntil { get; private set; }

    }
}
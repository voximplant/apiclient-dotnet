using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [AttachPhoneNumber] function result.
    /// </summary>
    public class NewAttachedPhoneInfoType
    {
        /// <summary>
        /// The phone ID
        /// </summary>
        [JsonProperty("phone_id")]
        public long PhoneId { get; private set; }

        /// <summary>
        /// The phone number
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// Country code, where the verification is required for the account. Currently, the only possible value for this field is `RU` (Russia)
        /// </summary>
        [JsonProperty("required_verification")]
        public string RequiredVerification { get; private set; }

        /// <summary>
        /// The account verification status. Available only for RU accounts. The following values are possible: REQUIRED, IN_PROGRESS
        /// </summary>
        [JsonProperty("verification_status")]
        public string VerificationStatus { get; private set; }

        /// <summary>
        /// Unverified phone hold until the date in format: YYYY-MM-DD (if the account verification is required). The number is detached on that day automatically!
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("unverified_hold_until")]
        public DateTime? UnverifiedHoldUntil { get; private set; }

    }
}
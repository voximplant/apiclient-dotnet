using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The account verifications.
    /// </summary>
    public class AccountVerifications
    {
        /// <summary>
        /// The account ID
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; private set; }

        /// <summary>
        /// The account verifications
        /// </summary>
        [JsonProperty("verifications")]
        public AccountVerificationType[] Verifications { get; private set; }

    }
}
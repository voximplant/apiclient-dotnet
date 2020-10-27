using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class SIPRegistrationFailCallback
    {
        /// <summary>
        /// The SIP registration ID.
        /// </summary>
        [JsonProperty("sip_registration_id")]
        public long SipRegistrationId { get; private set; }

    }
}
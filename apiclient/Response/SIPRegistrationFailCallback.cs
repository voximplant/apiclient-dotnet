using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when one or several SIP registrations are failed. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class SIPRegistrationFailCallback
    {
        /// <summary>
        /// SIP registration array
        /// </summary>
        [JsonProperty("sip_registrations")]
        public SIPRegistrationIsFailedCallbackItem[] SipRegistrations { get; private set; }

    }
}
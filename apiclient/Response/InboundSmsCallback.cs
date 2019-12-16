using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The inbound SMS callback. Received as part of the [AccountCallback]
    /// structure.
    /// </summary>
    public class InboundSmsCallback
    {
        /// <summary>
        /// The inbound SMS info.
        /// </summary>
        [JsonProperty("sms_inbound")]
        public IReadOnlyList<InboundSmsCallbackItem> SmsInbound { get; private set; }

    }
}
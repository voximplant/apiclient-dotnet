using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The inbound SMS callback. Received as a part of the [AccountCallback] structure. If the <b>incoming_sms_notification_url</b> parameter is set, the notification of an inbound SMS will be sent to this url, otherwise, it will be sent to the general account URL.
    /// </summary>
    public class InboundSmsCallback
    {
        /// <summary>
        /// The inbound SMS info.
        /// </summary>
        [JsonProperty("sms_inbound")]
        public InboundSmsCallbackItem[] SmsInbound { get; private set; }

    }
}
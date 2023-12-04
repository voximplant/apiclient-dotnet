using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The incoming SMS callback. Received as a part of the [AccountCallback] structure. If the <b>incoming_sms_notification_url</b> parameter is set, the notification of an incoming SMS is sent to this url, otherwise, it is sent to the general account URL.
    /// </summary>
    public class InboundSmsCallback
    {
        /// <summary>
        /// The incoming SMS info
        /// </summary>
        [JsonProperty("sms_inbound")]
        public InboundSmsCallbackItem SmsInbound { get; private set; }

    }
}
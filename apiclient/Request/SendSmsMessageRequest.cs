using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SendSmsMessageRequest : BaseRequest
    {
        /// <summary>
        /// The source phone number.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// The destination phone number.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// The message text, up to 70 characters. The message of 71-140
        /// characters is billed like 2 messages; the message of 141-210
        /// characters is billed like 3 messages and so on.
        /// </summary>
        [JsonProperty("sms_body")]
        public string SmsBody { get; set; }

    }
}
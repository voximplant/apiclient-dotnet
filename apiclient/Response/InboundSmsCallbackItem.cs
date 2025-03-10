using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The details of the [InboundSmsCallback].
    /// </summary>
    public class InboundSmsCallbackItem
    {
        /// <summary>
        /// The source phone number
        /// </summary>
        [JsonProperty("source_number")]
        public string SourceNumber { get; private set; }

        /// <summary>
        /// The destination phone number
        /// </summary>
        [JsonProperty("destination_number")]
        public string DestinationNumber { get; private set; }

        /// <summary>
        /// The message
        /// </summary>
        [JsonProperty("sms_body")]
        public string SmsBody { get; private set; }

    }
}
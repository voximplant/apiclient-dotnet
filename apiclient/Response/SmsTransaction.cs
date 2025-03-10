using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The part of the [A2PSendSms] function result.
    /// </summary>
    public class SmsTransaction
    {
        /// <summary>
        /// Message ID
        /// </summary>
        [JsonProperty("message_id")]
        public long MessageId { get; private set; }

        /// <summary>
        /// The SMS destination number
        /// </summary>
        [JsonProperty("destination_number")]
        public string DestinationNumber { get; private set; }

    }
}
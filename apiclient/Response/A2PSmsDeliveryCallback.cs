using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The A2P SMS delivery status callback.
    /// </summary>
    public class A2PSmsDeliveryCallback
    {
        /// <summary>
        /// The SMS delivery ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; private set; }

        /// <summary>
        /// The source number
        /// </summary>
        [JsonProperty("source_number")]
        public string SourceNumber { get; private set; }

        /// <summary>
        /// The SMS delivery status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }

        /// <summary>
        /// The destination number(s)
        /// </summary>
        [JsonProperty("destination_numbers")]
        public string DestinationNumbers { get; private set; }

    }
}
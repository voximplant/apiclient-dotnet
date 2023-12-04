using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The part of the [A2PSendSms] function result.
    /// </summary>
    public class FailedSms
    {
        /// <summary>
        /// The SMS destination number
        /// </summary>
        [JsonProperty("destination_number")]
        public string DestinationNumber { get; private set; }

        /// <summary>
        /// The error description
        /// </summary>
        [JsonProperty("error_description")]
        public string ErrorDescription { get; private set; }

        /// <summary>
        /// The error code
        /// </summary>
        [JsonProperty("error_code")]
        public long ErrorCode { get; private set; }

    }
}
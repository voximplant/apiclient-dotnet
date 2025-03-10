using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when a caller ID is expired.
    /// </summary>
    public class ExpiredCallerIDCallback
    {
        /// <summary>
        /// The list of the expired Caller IDs
        /// </summary>
        [JsonProperty("callerids")]
        public string[] Callerids { get; private set; }

    }
}
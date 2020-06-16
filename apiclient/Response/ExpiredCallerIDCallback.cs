using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details.
    /// </summary>
    public class ExpiredCallerIDCallback
    {
        /// <summary>
        /// The list of the expired Caller IDs.
        /// </summary>
        [JsonProperty("callerids")]
        public string[] Callerids { get; private set; }

    }
}
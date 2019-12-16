using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The available resource parameters.
    /// </summary>
    public class ResourceParams
    {
        /// <summary>
        /// The allowed parameter prefixes. Example: 7495
        /// </summary>
        [JsonProperty("allowed")]
        public string[] Allowed { get; private set; }

        /// <summary>
        /// The forbidden parameter prefixes. Example: 7800
        /// </summary>
        [JsonProperty("forbidden")]
        public string[] Forbidden { get; private set; }

        /// <summary>
        /// The requested parameters. Example: 79263331122
        /// </summary>
        [JsonProperty("requested")]
        public string[] Requested { get; private set; }

    }
}
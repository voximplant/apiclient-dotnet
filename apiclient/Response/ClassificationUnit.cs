using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Info about services that were provided.
    /// </summary>
    public class ClassificationUnit
    {
        /// <summary>
        /// The classification type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The classification info.
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; private set; }

        /// <summary>
        /// Classification error code (if any).
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; private set; }

    }
}
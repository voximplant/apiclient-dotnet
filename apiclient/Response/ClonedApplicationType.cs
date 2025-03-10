using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The cloned application info.
    /// </summary>
    public class ClonedApplicationType
    {
        /// <summary>
        /// The application ID
        /// </summary>
        [JsonProperty("application_id")]
        public long ApplicationId { get; private set; }

        /// <summary>
        /// The full application name
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; private set; }

        /// <summary>
        /// The cloned rules
        /// </summary>
        [JsonProperty("users")]
        public ClonedRuleType[] Users { get; private set; }

    }
}
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when a plan (IM, MAU) is changed. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class PlanConfigCallback
    {
        /// <summary>
        /// The plan type. The possible values are IM, MAU
        /// </summary>
        [JsonProperty("plan_type")]
        public string PlanType { get; private set; }

        /// <summary>
        /// The plan name
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; private set; }

        /// <summary>
        /// The account plan package array
        /// </summary>
        [JsonProperty("packages")]
        public PlanPackageConfig[] Packages { get; private set; }

    }
}
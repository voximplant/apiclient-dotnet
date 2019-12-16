using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The plan package info.
    /// </summary>
    public class PlanPackageType
    {
        /// <summary>
        /// The price group IDs.
        /// </summary>
        [JsonProperty("price_group_id")]
        public long?[] PriceGroupId { get; private set; }

        /// <summary>
        /// The package name.
        /// </summary>
        [JsonProperty("package_name")]
        public string PackageName { get; private set; }

        /// <summary>
        /// Is overrun enabled?
        /// </summary>
        [JsonProperty("may_overrun")]
        public bool? MayOverrun { get; private set; }

        /// <summary>
        /// The overrun amount.
        /// </summary>
        [JsonProperty("overrun_price")]
        public decimal? OverrunPrice { get; private set; }

        /// <summary>
        /// The number of resources (e.g., messages) per overrun.
        /// </summary>
        [JsonProperty("overrun_resources")]
        public long? OverrunResources { get; private set; }

        /// <summary>
        /// The package size.
        /// </summary>
        [JsonProperty("package_size")]
        public long? PackageSize { get; private set; }

    }
}
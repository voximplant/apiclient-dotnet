using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The account plan package info.
    /// </summary>
    public class AccountPlanPackageType
    {
        /// <summary>
        /// The price group IDs.
        /// </summary>
        [JsonProperty("price_group_id")]
        public long[] PriceGroupId { get; private set; }

        /// <summary>
        /// The package name.
        /// </summary>
        [JsonProperty("package_name")]
        public string PackageName { get; private set; }

        /// <summary>
        /// Overrun is enabled.
        /// </summary>
        [JsonProperty("may_overrun")]
        public bool MayOverrun { get; private set; }

        /// <summary>
        /// The overrun amount.
        /// </summary>
        [JsonProperty("overrun_price")]
        public decimal OverrunPrice { get; private set; }

        /// <summary>
        /// The number of resources (e.g., messages) per overrun.
        /// </summary>
        [JsonProperty("overrun_resources")]
        public long OverrunResources { get; private set; }

        /// <summary>
        /// The resource left in the package.
        /// </summary>
        [JsonProperty("resource_left")]
        public long ResourceLeft { get; private set; }

        /// <summary>
        /// The current package size (including overrun).
        /// </summary>
        [JsonProperty("package_size")]
        public long PackageSize { get; private set; }

        /// <summary>
        /// The original package size (excluding overrun).
        /// </summary>
        [JsonProperty("orig_package_size")]
        public long OrigPackageSize { get; private set; }

    }
}
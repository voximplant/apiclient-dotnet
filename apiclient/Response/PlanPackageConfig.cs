using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details.
    /// </summary>
    public class PlanPackageConfig
    {
        /// <summary>
        /// The price group IDs
        /// </summary>
        [JsonProperty("price_group_id")]
        public long[] PriceGroupId { get; private set; }

        /// <summary>
        /// The package name
        /// </summary>
        [JsonProperty("package_name")]
        public string PackageName { get; private set; }

        /// <summary>
        /// The package UUID
        /// </summary>
        [JsonProperty("package_uuid")]
        public string PackageUuid { get; private set; }

        /// <summary>
        /// Overrun is enabled
        /// </summary>
        [JsonProperty("may_overrun")]
        public bool MayOverrun { get; private set; }

        /// <summary>
        /// The current package size (including overrun)
        /// </summary>
        [JsonProperty("package_size")]
        public long PackageSize { get; private set; }

    }
}
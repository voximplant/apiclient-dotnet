using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The resource price group.
    /// </summary>
    public class PriceGroup
    {
        /// <summary>
        /// The price group name. Example: Russia Mobile
        /// </summary>
        [JsonProperty("price_group_name")]
        public string PriceGroupName { get; private set; }

        /// <summary>
        /// The price group ID
        /// </summary>
        [JsonProperty("price_group_id")]
        public long PriceGroupId { get; private set; }

        /// <summary>
        /// The price for the 'num_resources_per_price' resource count
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; private set; }

        /// <summary>
        /// The resource count per price
        /// </summary>
        [JsonProperty("num_resources_per_price")]
        public long NumResourcesPerPrice { get; private set; }

        /// <summary>
        /// The resource rounding quantum
        /// </summary>
        [JsonProperty("quantum")]
        public long Quantum { get; private set; }

        /// <summary>
        /// The available resource parameters
        /// </summary>
        [JsonProperty("params")]
        public ResourceParams Params { get; private set; }

    }
}
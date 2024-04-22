using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetRegions] function result.
    /// </summary>
    public class RegulationRegionRecord
    {
        /// <summary>
        /// The regulation address ID
        /// </summary>
        [JsonProperty("phone_region_id")]
        public long PhoneRegionId { get; private set; }

        /// <summary>
        /// The region name
        /// </summary>
        [JsonProperty("phone_region_name")]
        public string PhoneRegionName { get; private set; }

        /// <summary>
        /// The phone region code 
        /// </summary>
        [JsonProperty("phone_region_code")]
        public string PhoneRegionCode { get; private set; }

        /// <summary>
        /// Whether need to confirm the address
        /// </summary>
        [JsonProperty("is_need_regulation_address")]
        public bool IsNeedRegulationAddress { get; private set; }

        /// <summary>
        /// The regulation address type. Available: LOCAL, NATIONAL, WORLDWIDE
        /// </summary>
        [JsonProperty("regulation_address_type")]
        public string RegulationAddressType { get; private set; }

    }
}
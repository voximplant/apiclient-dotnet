using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The country record.
    /// </summary>
    public class RegulationCountry
    {
        /// <summary>
        /// The country code A2
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; private set; }

        /// <summary>
        /// The country name
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; private set; }

    }
}
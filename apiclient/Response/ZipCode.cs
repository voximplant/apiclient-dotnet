using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The ZipCode record.
    /// </summary>
    public class ZipCode
    {
        /// <summary>
        /// The city name
        /// </summary>
        [JsonProperty("city")]
        public string City { get; private set; }

        /// <summary>
        /// The zip code
        /// </summary>
        [JsonProperty("zip_code")]
        public string Number { get; private set; }

    }
}
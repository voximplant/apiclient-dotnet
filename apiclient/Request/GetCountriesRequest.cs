using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetCountriesRequest : BaseRequest
    {
        /// <summary>
        /// The country code according to the <b>ISO 3166-1 alpha-2</b>.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

    }
}
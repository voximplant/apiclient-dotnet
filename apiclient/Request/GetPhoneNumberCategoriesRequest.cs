using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetPhoneNumberCategoriesRequest : BaseRequest
    {
        /// <summary>
        /// The country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Flag allows you to display phone number categories only of the
        /// sandbox, real or all .The following values are possible: 'all',
        /// 'true', 'false'.
        /// </summary>
        [JsonProperty("sandbox")]
        public string Sandbox { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetPhoneNumberCountryStatesRequest : BaseRequest
    {
        /// <summary>
        /// The country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone category name. See the GetPhoneNumberCategories function.
        /// </summary>
        [JsonProperty("phone_category_name")]
        public string PhoneCategoryName { get; set; }

        /// <summary>
        /// The country state code (example: AL, CA, ... ).
        /// </summary>
        [JsonProperty("country_state")]
        public string CountryState { get; set; }

    }
}
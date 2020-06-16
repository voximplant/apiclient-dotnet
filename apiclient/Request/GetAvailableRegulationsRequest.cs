using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetAvailableRegulationsRequest : BaseRequest
    {
        /// <summary>
        /// The country code according to the <b>ISO 3166-1 alpha-2</b>.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone category name. See the [GetPhoneNumberCategories] method.
        /// </summary>
        [JsonProperty("phone_category_name")]
        public string PhoneCategoryName { get; set; }

        /// <summary>
        /// The phone region code. See the [GetRegions] method.
        /// </summary>
        [JsonProperty("phone_region_code")]
        public string PhoneRegionCode { get; set; }

    }
}
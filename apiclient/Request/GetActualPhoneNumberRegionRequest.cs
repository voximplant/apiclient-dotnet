using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetActualPhoneNumberRegionRequest : BaseRequest
    {
        /// <summary>
        /// The country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone category name. See the <a
        /// href='//voximplant.com/docs/references/httpapi/managing_phone_numbers#getphonenumbercategoriesb'>GetPhoneNumberCategories</a>
        /// method.
        /// </summary>
        [JsonProperty("phone_category_name")]
        public string PhoneCategoryName { get; set; }

        /// <summary>
        /// The phone region ID to filter.
        /// </summary>
        [JsonProperty("phone_region_id")]
        public long? PhoneRegionId { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetPhoneNumberRegionsRequest : BaseRequest
    {
        /// <summary>
        /// The country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone category name. See the <a
        /// href='//voximplant.com/docs/references/httpapi/managing_phone_numbers#getphonenumbercategories'>GetPhoneNumberCategories</a>
        /// method.
        /// </summary>
        [JsonProperty("phone_category_name")]
        public string PhoneCategoryName { get; set; }

        /// <summary>
        /// The country state code (example: AL, CA, ... ).
        /// </summary>
        [JsonProperty("country_state")]
        public string CountryState { get; set; }

        /// <summary>
        /// Set to 'false' to show all the regions (with and without phone
        /// numbers in stock).
        /// </summary>
        [JsonProperty("omit_empty")]
        public bool? OmitEmpty { get; set; }

        /// <summary>
        /// The phone region ID to filter.
        /// </summary>
        [JsonProperty("phone_region_id")]
        public long? PhoneRegionId { get; set; }

        /// <summary>
        /// The phone region name to filter.
        /// </summary>
        [JsonProperty("phone_region_name")]
        public string PhoneRegionName { get; set; }

        /// <summary>
        /// The region phone prefix to filter.
        /// </summary>
        [JsonProperty("phone_region_code")]
        public string PhoneRegionCode { get; set; }

    }
}
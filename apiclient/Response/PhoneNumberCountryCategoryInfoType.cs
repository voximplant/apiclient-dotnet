using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The 'phone_categories' element of the [GetPhoneNumberCategories] function result.
    /// </summary>
    public class PhoneNumberCountryCategoryInfoType
    {
        /// <summary>
        /// The phone category name
        /// </summary>
        [JsonProperty("phone_category_name")]
        public string PhoneCategoryName { get; private set; }

        /// <summary>
        /// Whether the chosen phone number country has states
        /// </summary>
        [JsonProperty("country_has_states")]
        public bool CountryHasStates { get; private set; }

        /// <summary>
        /// The localized country name
        /// </summary>
        [JsonProperty("localized_country_name")]
        public string LocalizedCountryName { get; private set; }

        /// <summary>
        /// The localized phone category name
        /// </summary>
        [JsonProperty("localized_phone_category_name")]
        public string LocalizedPhoneCategoryName { get; private set; }

        /// <summary>
        /// The localized phone region name
        /// </summary>
        [JsonProperty("localized_phone_region_name")]
        public string LocalizedPhoneRegionName { get; private set; }

    }
}
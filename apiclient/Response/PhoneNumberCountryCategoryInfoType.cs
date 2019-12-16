using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The 'phone_categories' element of the [GetPhoneNumberCategories]
    /// function result.
    /// </summary>
    public class PhoneNumberCountryCategoryInfoType
    {
        /// <summary>
        /// The phone category name.
        /// </summary>
        [JsonProperty("phone_category_name")]
        public string PhoneCategoryName { get; private set; }

        /// <summary>
        /// True if a country state is used to choose the phone with the category.
        /// </summary>
        [JsonProperty("country_has_states")]
        public bool? CountryHasStates { get; private set; }

    }
}
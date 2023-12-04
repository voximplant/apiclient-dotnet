using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetPhoneNumberCategories] function result.
    /// </summary>
    public class PhoneNumberCountryInfoType
    {
        /// <summary>
        /// The country code
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; private set; }

        /// <summary>
        /// The country phone prefix
        /// </summary>
        [JsonProperty("phone_prefix")]
        public string PhonePrefix { get; private set; }

        /// <summary>
        /// True if can list phone numbers
        /// </summary>
        [JsonProperty("can_list_phone_numbers")]
        public bool CanListPhoneNumbers { get; private set; }

        /// <summary>
        /// The phone categories
        /// </summary>
        [JsonProperty("phone_categories")]
        public PhoneNumberCountryCategoryInfoType[] PhoneCategories { get; private set; }

        /// <summary>
        /// If <b>true</b>, you need to make a request to enable calls to emergency numbers
        /// </summary>
        [JsonProperty("emergency_calls_to_be_enabled")]
        public bool EmergencyCallsToBeEnabled { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetNewPhoneNumbers] function result item.
    /// </summary>
    public class NewPhoneInfoType
    {
        /// <summary>
        /// The phone ID.
        /// </summary>
        [JsonProperty("phone_id")]
        public long PhoneId { get; private set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// The phone monthly charge.
        /// </summary>
        [JsonProperty("phone_price")]
        public decimal PhonePrice { get; private set; }

        /// <summary>
        /// The phone installation price (without the first monthly fee).
        /// </summary>
        [JsonProperty("phone_installation_price")]
        public decimal PhoneInstallationPrice { get; private set; }

        /// <summary>
        /// The phone country code (2 symbols).
        /// </summary>
        [JsonProperty("phone_country_code")]
        public string PhoneCountryCode { get; private set; }

        /// <summary>
        /// The charge period in 24-h format: Y-M-D H:m:s. Example: 0-1-0 0:0:0 is 1 month.
        /// </summary>
        [JsonProperty("phone_period")]
        public string PhonePeriod { get; private set; }

        /// <summary>
        /// The phone category name (MOBILE, GEOGRAPHIC, TOLLFREE, MOSCOW495)
        /// </summary>
        [JsonProperty("phone_category_name")]
        public string PhoneCategoryName { get; private set; }

        /// <summary>
        /// The phone region name
        /// </summary>
        [JsonProperty("phone_region_name")]
        public string PhoneRegionName { get; private set; }

    }
}
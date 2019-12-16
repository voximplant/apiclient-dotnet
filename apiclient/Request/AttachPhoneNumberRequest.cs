using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AttachPhoneNumberRequest : BaseRequest
    {
        /// <summary>
        /// The phone count to attach.
        /// </summary>
        [JsonProperty("phone_count")]
        public long? PhoneCount { get; set; }

        /// <summary>
        /// The phone number that can be used instead of <b>phone_count</b>. See
        /// the [GetNewPhoneNumbers] method.
        /// </summary>
        [JsonProperty("phone_number")]
        public Argument<string> PhoneNumber { get; set; }

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
        /// The country state. See the <a
        /// href='//voximplant.com/docs/references/httpapi/managing_phone_numbers#getphonenumbercategories'>GetPhoneNumberCategories</a>
        /// and <a
        /// href='//voximplant.com/docs/references/httpapi/managing_phone_numbers#getphonenumbercountrystates'>GetPhoneNumberCountryStates</a>
        /// methods.
        /// </summary>
        [JsonProperty("country_state")]
        public string CountryState { get; set; }

        /// <summary>
        /// The phone region ID. See the <a
        /// href='//voximplant.com/docs/references/httpapi/managing_phone_numbers#getphonenumberregionsb'>GetPhoneNumberRegions</a>
        /// method.
        /// </summary>
        [JsonProperty("phone_region_id")]
        public long? PhoneRegionId { get; set; }

        /// <summary>
        /// The phone regulation address ID.
        /// </summary>
        [JsonProperty("regulation_address_id")]
        public long? RegulationAddressId { get; set; }

        /// <summary>
        /// The force verification flag.
        /// </summary>
        [JsonProperty("force_verification")]
        public bool? ForceVerification { get; set; }

    }
}
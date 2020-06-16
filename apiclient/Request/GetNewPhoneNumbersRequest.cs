using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetNewPhoneNumbersRequest : BaseRequest
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
        /// The country state. See the GetPhoneNumberCategories and
        /// GetPhoneNumberCountryStates functions.
        /// </summary>
        [JsonProperty("country_state")]
        public string CountryState { get; set; }

        /// <summary>
        /// The phone region ID. See the [GetPhoneNumberRegions] method.
        /// </summary>
        [JsonProperty("phone_region_id")]
        public long? PhoneRegionId { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetRegulationsAddressRequest : BaseRequest
    {
        /// <summary>
        /// The country code according to the <b>ISO 3166-1 alpha-2</b>.
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
        /// The phone region code. See the <a
        /// href='//voximplant.com/docs/references/httpapi/managing_regulation_address#getregions'>GetRegions</a>
        /// method.
        /// </summary>
        [JsonProperty("phone_region_code")]
        public string PhoneRegionCode { get; set; }

        /// <summary>
        /// The regulation address ID.
        /// </summary>
        [JsonProperty("regulation_address_id")]
        public long? RegulationAddressId { get; set; }

        /// <summary>
        /// The regulation address type ID.
        /// </summary>
        [JsonProperty("verification_id")]
        public long? VerificationId { get; set; }

        /// <summary>
        /// Show only verified regulation address.
        /// </summary>
        [JsonProperty("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// Show only in progress regulation address.
        /// </summary>
        [JsonProperty("in_progress")]
        public bool? InProgress { get; set; }

        /// <summary>
        /// Return with phone_region_code parameters
        /// </summary>
        [JsonProperty("with_region_code")]
        public bool? WithRegionCode { get; set; }

    }
}
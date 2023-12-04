using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetRegulationsAddress] and [GetAvailableRegulations] result.
    /// </summary>
    public class RegulationAddress
    {
        /// <summary>
        /// The regulation address ID
        /// </summary>
        [JsonProperty("regulation_address_id")]
        public long RegulationAddressId { get; private set; }

        /// <summary>
        /// The external ID
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The country code
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; private set; }

        /// <summary>
        /// The phone category name
        /// </summary>
        [JsonProperty("phone_category_name")]
        public string PhoneCategoryName { get; private set; }

        /// <summary>
        /// The salutation. Possible values: MR, MS, COMPANY
        /// </summary>
        [JsonProperty("salutation")]
        public string Salutation { get; private set; }

        /// <summary>
        /// The company name
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; private set; }

        /// <summary>
        /// The first name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; private set; }

        /// <summary>
        /// The last name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; private set; }

        /// <summary>
        /// The owner country code
        /// </summary>
        [JsonProperty("owner_country_code")]
        public string OwnerCountryCode { get; private set; }

        /// <summary>
        /// The city name
        /// </summary>
        [JsonProperty("city")]
        public string City { get; private set; }

        /// <summary>
        /// The zip code
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; private set; }

        /// <summary>
        /// The zip code
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; private set; }

        /// <summary>
        /// The builder number
        /// </summary>
        [JsonProperty("builder_number")]
        public string BuilderNumber { get; private set; }

        /// <summary>
        /// The builder latter
        /// </summary>
        [JsonProperty("builder_latter")]
        public string BuilderLatter { get; private set; }

        /// <summary>
        /// The status verification. Possible values: IN_PROGRESS, VERIFIED, DECLINED
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }

        /// <summary>
        /// The reject message
        /// </summary>
        [JsonProperty("reject_message")]
        public string RejectMessage { get; private set; }

    }
}
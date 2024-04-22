using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetPhoneNumberRegions] function result.
    /// </summary>
    public class PhoneNumberCountryRegionInfoType
    {
        /// <summary>
        /// The region ID
        /// </summary>
        [JsonProperty("phone_region_id")]
        public long PhoneRegionId { get; private set; }

        /// <summary>
        /// The full region name
        /// </summary>
        [JsonProperty("phone_region_name")]
        public string PhoneRegionName { get; private set; }

        /// <summary>
        /// The region phone prefix
        /// </summary>
        [JsonProperty("phone_region_code")]
        public string PhoneRegionCode { get; private set; }

        /// <summary>
        /// The phone number count in stock for the region
        /// </summary>
        [JsonProperty("phone_count")]
        public long PhoneCount { get; private set; }

        /// <summary>
        /// The account verification status. The following values are possible: REQUIRED, IN_PROGRESS, VERIFIED
        /// </summary>
        [JsonProperty("verification_status")]
        public string VerificationStatus { get; private set; }

        /// <summary>
        /// Whether verification is required for the account
        /// </summary>
        [JsonProperty("required_verification")]
        public bool? RequiredVerification { get; private set; }

        /// <summary>
        /// The charge period in 24-h format: Y-M-D H:m:s. Example: 0-1-0 0:0:0 is 1 month
        /// </summary>
        [JsonProperty("phone_period")]
        public string PhonePeriod { get; private set; }

        /// <summary>
        /// Whether to need proof of address
        /// </summary>
        [JsonProperty("is_need_regulation_address")]
        public bool? IsNeedRegulationAddress { get; private set; }

        /// <summary>
        /// The type of regulation address. The possible values are LOCAL, NATIONAL, WORLDWIDE
        /// </summary>
        [JsonProperty("regulation_address_type")]
        public string RegulationAddressType { get; private set; }

        /// <summary>
        /// Whether SMS is supported for phone numbers in this region. SMS needs to be explicitly enabled for a phone number via the [ControlSms] Management API before sending or receiving SMS. If SMS is supported and enabled, SMS can be sent from a phone number via the [SendSmsMessage] Management API and received via the [InboundSmsCallback] property of the HTTP callback. See <a href='/docs/guides/managementapi/callbacks'>this article</a> for HTTP callback details
        /// </summary>
        [JsonProperty("is_sms_supported")]
        public bool IsSmsSupported { get; private set; }

        /// <summary>
        /// [Array](MultipleNumbersPrice) with info about multiple numbers subscription for the child accounts
        /// </summary>
        [JsonProperty("multiple_numbers_price")]
        public MultipleNumbersPrice[] MultipleNumbersPrice { get; private set; }

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

        /// <summary>
        /// The phone number installation tax reserve
        /// </summary>
        [JsonProperty("phone_installation_tax_reserve")]
        public long PhoneInstallationTaxReserve { get; private set; }

        /// <summary>
        /// The phone number tax reserve
        /// </summary>
        [JsonProperty("phone_tax_reserve")]
        public long PhoneTaxReserve { get; private set; }

        /// <summary>
        /// Phone number price from the price list
        /// </summary>
        [JsonProperty("local_price")]
        public long? LocalPrice { get; private set; }

        /// <summary>
        /// Phone number installation price from the price list
        /// </summary>
        [JsonProperty("local_installation_price")]
        public long? LocalInstallationPrice { get; private set; }

        /// <summary>
        /// Price list currency
        /// </summary>
        [JsonProperty("local_currency")]
        public string LocalCurrency { get; private set; }

        /// <summary>
        /// Phone number price in the account currency
        /// </summary>
        [JsonProperty("account_price")]
        public long? AccountPrice { get; private set; }

        /// <summary>
        /// Phone number installation price in the account currency
        /// </summary>
        [JsonProperty("account_installation_price")]
        public long? AccountInstallationPrice { get; private set; }

        /// <summary>
        /// Account currency
        /// </summary>
        [JsonProperty("account_currency")]
        public string AccountCurrency { get; private set; }

    }
}
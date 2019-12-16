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
        /// The region ID.
        /// </summary>
        [JsonProperty("phone_region_id")]
        public long? PhoneRegionId { get; private set; }

        /// <summary>
        /// The full region name.
        /// </summary>
        [JsonProperty("phone_region_name")]
        public string PhoneRegionName { get; private set; }

        /// <summary>
        /// The region phone prefix.
        /// </summary>
        [JsonProperty("phone_region_code")]
        public string PhoneRegionCode { get; private set; }

        /// <summary>
        /// The phone number count in stock for the region.
        /// </summary>
        [JsonProperty("phone_count")]
        public long? PhoneCount { get; private set; }

        /// <summary>
        /// The account verification status. The following values are possible:
        /// REQUIRED, IN_PROGRESS, VERIFIED
        /// </summary>
        [JsonProperty("verification_status")]
        public string VerificationStatus { get; private set; }

        /// <summary>
        /// The required account verification name.
        /// </summary>
        [JsonProperty("required_verification")]
        public string RequiredVerification { get; private set; }

        /// <summary>
        /// The phone monthly charge.
        /// </summary>
        [JsonProperty("phone_price")]
        public decimal? PhonePrice { get; private set; }

        /// <summary>
        /// The phone installation price (without the first monthly fee).
        /// </summary>
        [JsonProperty("phone_installation_price")]
        public decimal? PhoneInstallationPrice { get; private set; }

        /// <summary>
        /// The charge period in 24-h format: Y-M-D H:m:s. Example: 0-1-0 0:0:0
        /// is 1 month.
        /// </summary>
        [JsonProperty("phone_period")]
        public string PhonePeriod { get; private set; }

        /// <summary>
        /// The flag of the need proof of address.
        /// </summary>
        [JsonProperty("is_need_regulation_address")]
        public bool? IsNeedRegulationAddress { get; private set; }

        /// <summary>
        /// The type of regulation address. Available values: LOCAL, NATIONAL,
        /// WORLDWIDE.
        /// </summary>
        [JsonProperty("regulation_address_type")]
        public string RegulationAddressType { get; private set; }

        /// <summary>
        /// If <b>true</b>, SMS is supported for phone numbers in this region.
        /// SMS needs to be explicitly enabled for a phone number via the <a
        /// href='//voximplant.com/docs/references/httpapi/managing_sms#controlsms'>/ControlSms</a>
        /// HTTP API before sending or receiving SMS. If SMS is supported and
        /// enabled, SMS can be sent from a phone number using the <a
        /// href='//voximplant.com/docs/references/httpapi/managing_sms#sendsmsmessage'>/SendSmsMessage</a>
        /// HTTP API and received using the [InboundSmsCallback] property of the
        /// HTTP callback. See <a
        /// href='//voximplant.com/blog/http-api-callbacks'>this article</a> for
        /// HTTP callback details.
        /// </summary>
        [JsonProperty("is_sms_supported")]
        public bool? IsSmsSupported { get; private set; }

        /// <summary>
        /// [Array](MultipleNumbersPrice) with info about multiple numbers
        /// subscription for the child accounts.
        /// </summary>
        [JsonProperty("multiple_numbers_price")]
        public IReadOnlyList<MultipleNumbersPrice> MultipleNumbersPrice { get; private set; }

    }
}
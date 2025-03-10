using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetPhoneNumbers] function result.
    /// </summary>
    public class AttachedPhoneInfoType
    {
        /// <summary>
        /// The phone ID
        /// </summary>
        [JsonProperty("phone_id")]
        public long PhoneId { get; private set; }

        /// <summary>
        /// The phone number
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// The phone monthly charge
        /// </summary>
        [JsonProperty("phone_price")]
        public decimal PhonePrice { get; private set; }

        /// <summary>
        /// The phone country code (2 symbols)
        /// </summary>
        [JsonProperty("phone_country_code")]
        public string PhoneCountryCode { get; private set; }

        /// <summary>
        /// The next renewal date in format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("phone_next_renewal")]
        public DateTime PhoneNextRenewal { get; private set; }

        /// <summary>
        /// The purchase date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("phone_purchase_date")]
        public DateTime PhonePurchaseDate { get; private set; }

        /// <summary>
        /// Whether the subscription is frozen
        /// </summary>
        [JsonProperty("deactivated")]
        public bool Deactivated { get; private set; }

        /// <summary>
        /// Whether the subscription is cancelled
        /// </summary>
        [JsonProperty("canceled")]
        public bool Canceled { get; private set; }

        /// <summary>
        /// Whether to charge automatically
        /// </summary>
        [JsonProperty("auto_charge")]
        public bool AutoCharge { get; private set; }

        /// <summary>
        /// The id of the bound application
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; private set; }

        /// <summary>
        /// The name of the bound application
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; private set; }

        /// <summary>
        /// The id of the bound rule
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; private set; }

        /// <summary>
        /// The name of the bound rule
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; private set; }

        /// <summary>
        /// The phone category name (MOBILE, GEOGRAPHIC, TOLLFREE, MOSCOW495)
        /// </summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; private set; }

        /// <summary>
        /// Whether the verification is required for the account
        /// </summary>
        [JsonProperty("required_verification")]
        public string RequiredVerification { get; private set; }

        /// <summary>
        /// The account verification status. The following values are possible: REQUIRED, IN_PROGRESS, VERIFIED
        /// </summary>
        [JsonProperty("verification_status")]
        public string VerificationStatus { get; private set; }

        /// <summary>
        /// Unverified phone hold until the date in format: YYYY-MM-DD (if the account verification is required). The number is detached on that day automatically!
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("unverified_hold_until")]
        public DateTime? UnverifiedHoldUntil { get; private set; }

        /// <summary>
        /// Whether a not verified account can use the phone
        /// </summary>
        [JsonProperty("can_be_used")]
        public bool CanBeUsed { get; private set; }

        /// <summary>
        /// Whether SMS is supported for this phone number. SMS needs to be explicitly enabled via the [ControlSms] Management API before sending or receiving SMS. If SMS is supported and enabled, SMS can be sent from this phone number via the [SendSmsMessage] Management API and received via the [InboundSmsCallback] property of the HTTP callback. See <a href='/docs/guides/managementapi/callbacks'>this article</a> for HTTP callback details
        /// </summary>
        [JsonProperty("is_sms_supported")]
        public bool IsSmsSupported { get; private set; }

        /// <summary>
        /// Whether SMS sending and receiving is enabled for this phone number via the [ControlSms] Management API
        /// </summary>
        [JsonProperty("is_sms_enabled")]
        public bool IsSmsEnabled { get; private set; }

        /// <summary>
        /// If set, the callback of an incoming SMS is sent to this url, otherwise, it is sent to the general account URL
        /// </summary>
        [JsonProperty("incoming_sms_callback_url")]
        public string IncomingSmsCallbackUrl { get; private set; }

        /// <summary>
        /// Whether you need to make a request to enable calls to emergency numbers
        /// </summary>
        [JsonProperty("emergency_calls_to_be_enabled")]
        public bool EmergencyCallsToBeEnabled { get; private set; }

        /// <summary>
        /// Whether calls to emergency numbers are enabled
        /// </summary>
        [JsonProperty("emergency_calls_enabled")]
        public bool EmergencyCallsEnabled { get; private set; }

        /// <summary>
        /// Phone number subscription ID
        /// </summary>
        [JsonProperty("subscription_id")]
        public long SubscriptionId { get; private set; }

        /// <summary>
        /// Full application name, e.g. myapp.myaccount.n1.voximplant.com
        /// </summary>
        [JsonProperty("extended_application_name")]
        public string ExtendedApplicationName { get; private set; }

        /// <summary>
        /// Phone region name
        /// </summary>
        [JsonProperty("phone_region_name")]
        public string PhoneRegionName { get; private set; }

        /// <summary>
        /// UTC date of an event associated with the number in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("modified")]
        public DateTime Modified { get; private set; }

    }
}
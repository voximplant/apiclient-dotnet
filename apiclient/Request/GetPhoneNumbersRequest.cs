using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetPhoneNumbersRequest : BaseRequest
    {
        /// <summary>
        /// The particular phone ID to filter
        /// </summary>
        [JsonProperty("phone_id")]
        public long? PhoneId { get; set; }

        /// <summary>
        /// The application ID.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name that can be used instead of
        /// <b>application_id</b>.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Is a phone bound to an application.
        /// </summary>
        [JsonProperty("is_bound_to_application")]
        public bool? IsBoundToApplication { get; set; }

        /// <summary>
        /// The phone number start to filter
        /// </summary>
        [JsonProperty("phone_template")]
        public string PhoneTemplate { get; set; }

        /// <summary>
        /// The country code list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("country_code")]
        public Argument<string> CountryCode { get; set; }

        /// <summary>
        /// The phone category name. See the [GetPhoneNumberCategories] method.
        /// </summary>
        [JsonProperty("phone_category_name")]
        public string PhoneCategoryName { get; set; }

        /// <summary>
        /// The flag of the canceled (deleted) subscription to filter.
        /// </summary>
        [JsonProperty("canceled")]
        public bool? Canceled { get; set; }

        /// <summary>
        /// The flag of the deactivated (frozen) subscription to filter.
        /// </summary>
        [JsonProperty("deactivated")]
        public bool? Deactivated { get; set; }

        /// <summary>
        /// The auto_charge flag to filter.
        /// </summary>
        [JsonProperty("auto_charge")]
        public bool? AutoCharge { get; set; }

        /// <summary>
        /// The UTC 'from' date filter in format: YYYY-MM-DD
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd")]
        [JsonProperty("from_phone_next_renewal")]
        public DateTime? FromPhoneNextRenewal { get; set; }

        /// <summary>
        /// The UTC 'to' date filter in format: YYYY-MM-DD
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd")]
        [JsonProperty("to_phone_next_renewal")]
        public DateTime? ToPhoneNextRenewal { get; set; }

        /// <summary>
        /// The UTC 'from' date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("from_phone_purchase_date")]
        public DateTime? FromPhonePurchaseDate { get; set; }

        /// <summary>
        /// The UTC 'to' date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("to_phone_purchase_date")]
        public DateTime? ToPhonePurchaseDate { get; set; }

        /// <summary>
        /// The child account ID list separated by the ';' symbol or the 'all'
        /// value.
        /// </summary>
        [JsonProperty("child_account_id")]
        public Argument<long> ChildAccountId { get; set; }

        /// <summary>
        /// Set true to get the children phones only.
        /// </summary>
        [JsonProperty("children_phones_only")]
        public bool? ChildrenPhonesOnly { get; set; }

        /// <summary>
        /// The required account verification name to filter.
        /// </summary>
        [JsonProperty("verification_name")]
        public string VerificationName { get; set; }

        /// <summary>
        /// The account verification status list separated by the ';' symbol. The
        /// following values are possible: REQUIRED, IN_PROGRESS, VERIFIED
        /// </summary>
        [JsonProperty("verification_status")]
        public Argument<string> VerificationStatus { get; set; }

        /// <summary>
        /// Unverified phone hold until the date (from ...) in format: YYYY-MM-DD
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd")]
        [JsonProperty("from_unverified_hold_until")]
        public DateTime? FromUnverifiedHoldUntil { get; set; }

        /// <summary>
        /// Unverified phone hold until the date (... to) in format: YYYY-MM-DD
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd")]
        [JsonProperty("to_unverified_hold_until")]
        public DateTime? ToUnverifiedHoldUntil { get; set; }

        /// <summary>
        /// Can the unverified account use the phone?
        /// </summary>
        [JsonProperty("can_be_used")]
        public bool? CanBeUsed { get; set; }

        /// <summary>
        /// The following values are available: 'phone_number' (ascent order),
        /// 'phone_price' (ascent order), 'phone_country_code' (ascent order),
        /// 'deactivated' (deactivated first, active last), 'purchase_date'
        /// (descent order), 'phone_next_renewal' (ascent order),
        /// 'verification_status', 'unverified_hold_until' (ascent order),
        /// 'verification_name'.
        /// </summary>
        [JsonProperty("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Flag allows you to display only the numbers of the sandbox, real
        /// numbers, or all numbers. The following values are possible: 'all',
        /// 'true', 'false'.
        /// </summary>
        [JsonProperty("sandbox")]
        public string Sandbox { get; set; }

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

        /// <summary>
        /// The flag of the SMS support.
        /// </summary>
        [JsonProperty("sms_supported")]
        public bool? SmsSupported { get; set; }

        /// <summary>
        /// The region names list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("phone_region_name")]
        public Argument<string> PhoneRegionName { get; set; }

        /// <summary>
        /// The rule ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("rule_id")]
        public Argument<long> RuleId { get; set; }

        /// <summary>
        /// The rule names list separated by the ';' symbol. Can be used only if
        /// __application_id__ or __application_name__ is specified.
        /// </summary>
        [JsonProperty("rule_name")]
        public Argument<string> RuleName { get; set; }

        /// <summary>
        /// Is a number bound to any rule?
        /// </summary>
        [JsonProperty("is_bound_to_rule")]
        public bool? IsBoundToRule { get; set; }

    }
}
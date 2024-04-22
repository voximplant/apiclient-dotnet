using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetAccountInfo] function result.
    /// </summary>
    public class AccountInfoType
    {
        /// <summary>
        /// The account's ID
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; private set; }

        /// <summary>
        /// The account's name
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; private set; }

        /// <summary>
        /// The account's email
        /// </summary>
        [JsonProperty("account_email")]
        public string AccountEmail { get; private set; }

        /// <summary>
        /// The account API key. Use password or api_key authentication to show the api_key
        /// </summary>
        [JsonProperty("api_key")]
        public string ApiKey { get; private set; }

        /// <summary>
        /// The first name
        /// </summary>
        [JsonProperty("account_first_name")]
        public string AccountFirstName { get; private set; }

        /// <summary>
        /// The last name
        /// </summary>
        [JsonProperty("account_last_name")]
        public string AccountLastName { get; private set; }

        /// <summary>
        /// The UTC account created time in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; private set; }

        /// <summary>
        /// The notification language code (2 symbols, ISO639-1). Examples: en, ru
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; private set; }

        /// <summary>
        /// The account location (timezone). Examples: America/Los_Angeles, Etc/GMT-8, Etc/GMT+10
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; private set; }

        /// <summary>
        /// The min balance value to notify by email or SMS
        /// </summary>
        [JsonProperty("min_balance_to_notify")]
        public decimal? MinBalanceToNotify { get; private set; }

        /// <summary>
        /// Whether Voximplant notifications are required
        /// </summary>
        [JsonProperty("account_notifications")]
        public bool? AccountNotifications { get; private set; }

        /// <summary>
        /// Whether Voximplant plan changing notifications are required
        /// </summary>
        [JsonProperty("tariff_changing_notifications")]
        public bool? TariffChangingNotifications { get; private set; }

        /// <summary>
        /// Whether Voximplant news notifications are required
        /// </summary>
        [JsonProperty("news_notifications")]
        public bool? NewsNotifications { get; private set; }

        /// <summary>
        /// The company or businessman name
        /// </summary>
        [JsonProperty("billing_address_name")]
        public string BillingAddressName { get; private set; }

        /// <summary>
        /// The billing address country code (2 symbols, ISO 3166-1 alpha-2). Examples: US, RU, GB
        /// </summary>
        [JsonProperty("billing_address_country_code")]
        public string BillingAddressCountryCode { get; private set; }

        /// <summary>
        /// The office address
        /// </summary>
        [JsonProperty("billing_address_address")]
        public string BillingAddressAddress { get; private set; }

        /// <summary>
        /// The office ZIP
        /// </summary>
        [JsonProperty("billing_address_zip")]
        public string BillingAddressZip { get; private set; }

        /// <summary>
        /// The office phone number
        /// </summary>
        [JsonProperty("billing_address_phone")]
        public string BillingAddressPhone { get; private set; }

        /// <summary>
        /// The office state (US) or province (Canada), up to 100 characters. Examples: California, Illinois, British Columbia
        /// </summary>
        [JsonProperty("billing_address_state")]
        public string BillingAddressState { get; private set; }

        /// <summary>
        /// Whether the account is ctive
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; private set; }

        /// <summary>
        /// Whether account is blocked by Voximplant admins
        /// </summary>
        [JsonProperty("frozen")]
        public bool? Frozen { get; private set; }

        /// <summary>
        /// The account's money
        /// </summary>
        [JsonProperty("balance")]
        public decimal? Balance { get; private set; }

        /// <summary>
        /// The account's credit limit
        /// </summary>
        [JsonProperty("credit_limit")]
        public decimal? CreditLimit { get; private set; }

        /// <summary>
        /// The currency code (USD, RUR, EUR, ...)
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Whether Robokassa payments are allowed
        /// </summary>
        [JsonProperty("support_robokassa")]
        public bool? SupportRobokassa { get; private set; }

        /// <summary>
        /// Whether Bank card payments are allowed
        /// </summary>
        [JsonProperty("support_bank_card")]
        public bool? SupportBankCard { get; private set; }

        /// <summary>
        /// Whether Bank invoices are allowed
        /// </summary>
        [JsonProperty("support_invoice")]
        public bool? SupportInvoice { get; private set; }

        /// <summary>
        /// The custom data
        /// </summary>
        [JsonProperty("account_custom_data")]
        public string AccountCustomData { get; private set; }

        /// <summary>
        /// The allowed access entries (the API function names)
        /// </summary>
        [JsonProperty("access_entries")]
        public string[] AccessEntries { get; private set; }

        /// <summary>
        /// Whether the admin user permissions are granted
        /// </summary>
        [JsonProperty("with_access_entries")]
        public bool? WithAccessEntries { get; private set; }

        /// <summary>
        /// If URL is specified, Voximplant cloud makes HTTP POST requests to it when something happens. For a full list of reasons see the <b>type</b> field of the [AccountCallback] structure. The HTTP request has a JSON-encoded body that conforms to the [AccountCallbacks] structure
        /// </summary>
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; private set; }

        /// <summary>
        /// If salt string is specified, each HTTP request made by the Voximplant cloud toward the <b>callback_url</b> has a <b>salt</b> field set to MD5 hash of account information and salt. That hash can be used be a developer to ensure that HTTP request is made by the Voximplant cloud
        /// </summary>
        [JsonProperty("callback_salt")]
        public string CallbackSalt { get; private set; }

        /// <summary>
        /// Whether to send an email when a JS error occures
        /// </summary>
        [JsonProperty("send_js_error")]
        public bool? SendJsError { get; private set; }

        /// <summary>
        /// The payments limits applicable to each payment method
        /// </summary>
        [JsonProperty("billing_limits")]
        public BillingLimitsType BillingLimits { get; private set; }

        /// <summary>
        /// Whether to activate one-way SMS
        /// </summary>
        [JsonProperty("a2p_sms_enabled")]
        public bool? A2pSmsEnabled { get; private set; }

    }
}
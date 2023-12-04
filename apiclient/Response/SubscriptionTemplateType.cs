using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The subscription template info.
    /// </summary>
    public class SubscriptionTemplateType
    {
        /// <summary>
        /// The subscription template ID
        /// </summary>
        [JsonProperty("subscription_template_id")]
        public long SubscriptionTemplateId { get; private set; }

        /// <summary>
        /// ID of the original currency
        /// </summary>
        [JsonProperty("currency_id")]
        public long CurrencyId { get; private set; }

        /// <summary>
        /// The subscription installation price (without the first monthly fee)
        /// </summary>
        [JsonProperty("installation_price")]
        public decimal InstallationPrice { get; private set; }

        /// <summary>
        /// The subscription installation price in the original currency
        /// </summary>
        [JsonProperty("installation_price_in_currency")]
        public long InstallationPriceInCurrency { get; private set; }

        /// <summary>
        /// The subscription monthly fee, including taxes and discounts
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; private set; }

        /// <summary>
        /// The subscription monthly fee in the original currency
        /// </summary>
        [JsonProperty("price_in_currency")]
        public long PriceInCurrency { get; private set; }

        /// <summary>
        /// The charge period in 24-h format: Y-M-D H:m:s. Example: 0-1-0 0:0:0 is 1 month
        /// </summary>
        [JsonProperty("period")]
        public string Period { get; private set; }

        /// <summary>
        /// The subscription template type. The following values are possible: PHONE_NUM, SIP_REGISTRATION
        /// </summary>
        [JsonProperty("subscription_template_type")]
        public string Type { get; private set; }

        /// <summary>
        /// The subscription template name (example: SIP registration, Phone GB, Phone RU 495, ...)
        /// </summary>
        [JsonProperty("subscription_template_name")]
        public string SubscriptionTemplateName { get; private set; }

        /// <summary>
        /// Verification is required for the account
        /// </summary>
        [JsonProperty("required_verification")]
        public bool RequiredVerification { get; private set; }

        /// <summary>
        /// The verification status. Possible values are REQUIRED, IN_PROGRESS, VERIFIED, NOT_REQUIRED
        /// </summary>
        [JsonProperty("verification_status")]
        public string VerificationStatus { get; private set; }

        /// <summary>
        /// The phone number installation tax reserve
        /// </summary>
        [JsonProperty("installation_tax_reserve")]
        public long InstallationTaxReserve { get; private set; }

        /// <summary>
        /// The phone number tax reserve
        /// </summary>
        [JsonProperty("tax_reserve")]
        public long TaxReserve { get; private set; }

    }
}
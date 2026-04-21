using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The subscription template info.
    /// </summary>
    public class SubscriptionTemplateType
    {
        /// <summary>
        /// Subscription's template ID
        /// </summary>
        [JsonProperty("subscription_template_id")]
        public long SubscriptionTemplateId { get; private set; }

        /// <summary>
        /// Subscription's currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Subscription's installation price (without the first monthly fee)
        /// </summary>
        [JsonProperty("installation_price")]
        public decimal InstallationPrice { get; private set; }

        /// <summary>
        /// Subscription's installation price in the original currency
        /// </summary>
        [JsonProperty("installation_price_in_currency")]
        public long InstallationPriceInCurrency { get; private set; }

        /// <summary>
        /// Subscription's monthly fee, including taxes and discounts
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; private set; }

        /// <summary>
        /// Subscription's monthly fee in the original currency
        /// </summary>
        [JsonProperty("price_in_currency")]
        public long PriceInCurrency { get; private set; }

        /// <summary>
        /// Charge period in 24-h format: Y-M-D H:m:s. Example: 0-1-0 0:0:0 is 1 month
        /// </summary>
        [JsonProperty("period")]
        public string Period { get; private set; }

        /// <summary>
        /// Subscription template type. The following values are possible: PHONE_NUM, SIP_REGISTRATION
        /// </summary>
        [JsonProperty("subscription_template_type")]
        public string Type { get; private set; }

        /// <summary>
        /// Subscription template name (example: SIP registration, Phone GB, Phone RU 495, ...)
        /// </summary>
        [JsonProperty("subscription_template_name")]
        public string SubscriptionTemplateName { get; private set; }

        /// <summary>
        /// Whether verification is required for the account
        /// </summary>
        [JsonProperty("required_verification")]
        public string RequiredVerification { get; private set; }

        /// <summary>
        /// Verification status. Possible values are REQUIRED, IN_PROGRESS, VERIFIED, NOT_REQUIRED
        /// </summary>
        [JsonProperty("verification_status")]
        public string VerificationStatus { get; private set; }

        /// <summary>
        /// Phone number's installation tax reserve
        /// </summary>
        [JsonProperty("installation_tax_reserve")]
        public long InstallationTaxReserve { get; private set; }

        /// <summary>
        /// Phone number's tax reserve
        /// </summary>
        [JsonProperty("tax_reserve")]
        public long TaxReserve { get; private set; }

    }
}
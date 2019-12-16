using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetSubscriptionPriceRequest : BaseRequest
    {
        /// <summary>
        /// The subscription template ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("subscription_template_id")]
        public Argument<long> SubscriptionTemplateId { get; set; }

        /// <summary>
        /// The subscription template type. The following values are possible:
        /// PHONE_NUM, SIP_REGISTRATION.
        /// </summary>
        [JsonProperty("subscription_template_type")]
        public string SubscriptionTemplateType { get; set; }

        /// <summary>
        /// The subscription template name  (example: SIP registration, Phone GB,
        /// Phone RU 495, ...).
        /// </summary>
        [JsonProperty("subscription_template_name")]
        public string SubscriptionTemplateName { get; set; }

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
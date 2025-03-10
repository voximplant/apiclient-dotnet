using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetChildAccountSubscriptionTemplates] function result.
    /// </summary>
    public class ChildAccountSubscriptionTemplateType
    {
        /// <summary>
        /// The subscription template ID
        /// </summary>
        [JsonProperty("subscription_template_id")]
        public long SubscriptionTemplateId { get; private set; }

        /// <summary>
        /// The subscription template name
        /// </summary>
        [JsonProperty("subscription_template_name")]
        public string SubscriptionTemplateName { get; private set; }

        /// <summary>
        /// The subscription template installation price
        /// </summary>
        [JsonProperty("installation_price")]
        public decimal InstallationPrice { get; private set; }

        /// <summary>
        /// The subscription template periodic price
        /// </summary>
        [JsonProperty("periodic_price")]
        public decimal PeriodicPrice { get; private set; }

    }
}
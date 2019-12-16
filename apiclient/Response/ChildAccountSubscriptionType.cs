using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [AddChildAccountSubscription] and [GetChildAccountSubscriptions]
    /// function result.
    /// </summary>
    public class ChildAccountSubscriptionType
    {
        /// <summary>
        /// The subscription ID.
        /// </summary>
        [JsonProperty("subscription_id")]
        public long? SubscriptionId { get; private set; }

        /// <summary>
        /// The subscription name.
        /// </summary>
        [JsonProperty("subscription_name")]
        public string SubscriptionName { get; private set; }

        /// <summary>
        /// The subscription template ID.
        /// </summary>
        [JsonProperty("subscription_template_id")]
        public long? SubscriptionTemplateId { get; private set; }

        /// <summary>
        /// Is the subscription prolonged automatically?
        /// </summary>
        [JsonProperty("auto_charge")]
        public bool? AutoCharge { get; private set; }

        /// <summary>
        /// The next charge UTC date in format: YYYY-MM-DD.
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("next_renewal")]
        public DateTime? NextRenewal { get; private set; }

        /// <summary>
        /// The periodic payment amount.
        /// </summary>
        [JsonProperty("periodic_price")]
        public decimal? PeriodicPrice { get; private set; }

        /// <summary>
        /// Is the subscription active?
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; private set; }

    }
}
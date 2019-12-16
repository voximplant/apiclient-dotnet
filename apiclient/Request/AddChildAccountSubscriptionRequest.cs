using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddChildAccountSubscriptionRequest : BaseRequest
    {
        /// <summary>
        /// The child account ID.
        /// </summary>
        [JsonProperty("child_account_id")]
        public long? ChildAccountId { get; set; }

        /// <summary>
        /// The subscription template ID.
        /// </summary>
        [JsonProperty("subscription_template_id")]
        public long? SubscriptionTemplateId { get; set; }

        /// <summary>
        /// The subscription name.
        /// </summary>
        [JsonProperty("subscription_name")]
        public string SubscriptionName { get; set; }

    }
}
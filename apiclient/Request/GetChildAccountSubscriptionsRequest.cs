using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetChildAccountSubscriptionsRequest : BaseRequest
    {
        /// <summary>
        /// The child account ID.
        /// </summary>
        [JsonProperty("child_account_id")]
        public long? ChildAccountId { get; set; }

        /// <summary>
        /// The subscription ID. If empty, then all the non-deactivated
        /// subscriptions for the current child account will be retrieved.
        /// </summary>
        [JsonProperty("subscription_id")]
        public long? SubscriptionId { get; set; }

    }
}
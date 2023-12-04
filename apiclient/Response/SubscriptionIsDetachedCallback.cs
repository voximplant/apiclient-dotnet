using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when a subscription is canceled. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class SubscriptionIsDetachedCallback
    {
        /// <summary>
        /// The detached subscription list
        /// </summary>
        [JsonProperty("subscriptions")]
        public SubscriptionIsDetachedCallbackItem[] Subscriptions { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the
    /// [AccountCallback] structure.
    /// </summary>
    public class SubscriptionIsDetachedCallback
    {
        /// <summary>
        /// The detached subscription list.
        /// </summary>
        [JsonProperty("subscriptions")]
        public IReadOnlyList<SubscriptionIsDetachedCallbackItem> Subscriptions { get; private set; }

    }
}
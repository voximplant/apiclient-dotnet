using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when a subscription is frozen. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class SubscriptionIsFrozenCallback
    {
        /// <summary>
        /// The frozen subscription list
        /// </summary>
        [JsonProperty("subscriptions")]
        public SubscriptionIsFrozenCallbackItem[] Subscriptions { get; private set; }

    }
}
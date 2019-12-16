using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the
    /// [AccountCallback] structure.
    /// </summary>
    public class SubscriptionIsFrozenCallback
    {
        /// <summary>
        /// The frozen subscription list.
        /// </summary>
        [JsonProperty("subscriptions")]
        public IReadOnlyList<SubscriptionIsFrozenCallbackItem> Subscriptions { get; private set; }

    }
}
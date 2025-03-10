using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when an unverified subscription is canceled. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class UnverifiedSubscriptionDetachedCallback
    {
        /// <summary>
        /// The frozen subscription list
        /// </summary>
        [JsonProperty("subscriptions")]
        public UnverifiedSubscriptionDetachedCallbackItem[] Subscriptions { get; private set; }

    }
}
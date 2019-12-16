using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the
    /// [AccountCallback] structure.
    /// </summary>
    public class RenewedSubscriptionsCallback
    {
        /// <summary>
        /// The renewed subscription list.
        /// </summary>
        [JsonProperty("subscriptions")]
        public IReadOnlyList<RenewedSubscriptionsCallbackItem> Subscriptions { get; private set; }

    }
}
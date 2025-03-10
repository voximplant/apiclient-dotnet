using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when subscriptions are renewed. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class RenewedSubscriptionsCallback
    {
        /// <summary>
        /// The renewed subscription list
        /// </summary>
        [JsonProperty("subscriptions")]
        public RenewedSubscriptionsCallbackItem[] Subscriptions { get; private set; }

    }
}
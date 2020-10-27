using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details.
    /// </summary>
    public class SubscriptionIsDetachedCallbackItem
    {
        /// <summary>
        /// The subscription type, example: PHONE_NUM, SIP_REGISTRATION
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The subscription description (details). Example: the subscribed phone number.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

    }
}
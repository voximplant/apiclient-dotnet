using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details.
    /// </summary>
    public class UnverifiedSubscriptionDetachedCallbackItem
    {
        /// <summary>
        /// The subscription type, example: PHONE_NUM, SIP_REGISTRATION
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The subscription description (details). Example: the subscribed phone number
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Info about the phone numbers or sip registrations that the subscription is attached to
        /// </summary>
        [JsonProperty("details")]
        public SubscriptionCallbackDetails[] Details { get; private set; }

    }
}
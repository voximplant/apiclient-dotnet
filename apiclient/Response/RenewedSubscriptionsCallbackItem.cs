using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details.
    /// </summary>
    public class RenewedSubscriptionsCallbackItem
    {
        /// <summary>
        /// The subscription type, example: PHONE_NUM, SIP_REGISTRATION, PLAN
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The subscription description (details). Example: the subscribed phone number
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// The subscription cost
        /// </summary>
        [JsonProperty("cost")]
        public decimal Cost { get; private set; }

        /// <summary>
        /// The next renewal date, format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("next_renewal")]
        public DateTime NextRenewal { get; private set; }

        /// <summary>
        /// Info about the phone numbers or sip registrations that the subscription is attached to
        /// </summary>
        [JsonProperty("details")]
        public SubscriptionCallbackDetails[] Details { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetMoneyAmountToCharge] function result field.
    /// </summary>
    public class SubscriptionsToChargeType
    {
        /// <summary>
        /// The money amount to charge in the specified currency.
        /// </summary>
        [JsonProperty("subscription_amount")]
        public decimal SubscriptionAmount { get; private set; }

        /// <summary>
        /// The subscription type, example: PHONE_NUM, SIP_REGISTRATION
        /// </summary>
        [JsonProperty("subscription_type")]
        public string SubscriptionType { get; private set; }

        /// <summary>
        /// The subscription description (details). Example: the subscribed phone number.
        /// </summary>
        [JsonProperty("subscription_description")]
        public string SubscriptionDescription { get; private set; }

        /// <summary>
        /// The auto charge flag.
        /// </summary>
        [JsonProperty("subscription_auto_charge")]
        public bool SubscriptionAutoCharge { get; private set; }

        /// <summary>
        /// The next renewal date, format: YYYY-MM-DD. Displayed for only verified phone numbers.
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("subscription_next_renewal")]
        public DateTime? SubscriptionNextRenewal { get; private set; }

    }
}
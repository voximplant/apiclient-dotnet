using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DeactivateChildAccountSubscriptionRequest : BaseRequest
    {
        /// <summary>
        /// The subscription ID to be deactivated.
        /// </summary>
        [JsonProperty("subscription_id")]
        public long? SubscriptionId { get; set; }

        /// <summary>
        /// The child account ID.
        /// </summary>
        [JsonProperty("child_account_id")]
        public long? ChildAccountId { get; set; }

        /// <summary>
        /// The deactivation UTC date in 24-h format: YYYY-MM-DD HH:mm:ss. If
        /// empty, then the current date + 1 day is used as a cancellation date.
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("subscription_finish_date")]
        public DateTime? SubscriptionFinishDate { get; set; }

    }
}
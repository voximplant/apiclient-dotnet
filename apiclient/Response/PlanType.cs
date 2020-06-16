using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetAvailablePlans] function result item.
    /// </summary>
    public class PlanType
    {
        /// <summary>
        /// The current plan ID.
        /// </summary>
        [JsonProperty("plan_subscription_template_id")]
        public long? PlanSubscriptionTemplateId { get; private set; }

        /// <summary>
        /// The plan type. The possible values are: IM, MAU.
        /// </summary>
        [JsonProperty("plan_type")]
    
        public string Type { get; private set; }

        /// <summary>
        /// The plan name.
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; private set; }

        /// <summary>
        /// The plan monthly charge.
        /// </summary>
        [JsonProperty("periodic_charge")]
        public decimal? PeriodicCharge { get; private set; }

        /// <summary>
        /// The account package array.
        /// </summary>
        [JsonProperty("packages")]
        public IReadOnlyList<PlanPackageType> Packages { get; private set; }

    }
}
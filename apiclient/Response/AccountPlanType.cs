using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetAccountPlans] function result item.
    /// </summary>
    public class AccountPlanType
    {
        /// <summary>
        /// The current plan ID
        /// </summary>
        [JsonProperty("plan_subscription_template_id")]
        public long PlanSubscriptionTemplateId { get; private set; }

        /// <summary>
        /// The next charge date, format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("next_charge")]
        public DateTime NextCharge { get; private set; }

        /// <summary>
        /// The plan type. The possible values are IM, MAU
        /// </summary>
        [JsonProperty("plan_type")]
        public string PlanType { get; private set; }

        /// <summary>
        /// The plan name
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; private set; }

        /// <summary>
        /// The plan monthly charge
        /// </summary>
        [JsonProperty("periodic_charge")]
        public decimal PeriodicCharge { get; private set; }

        /// <summary>
        /// The account plan package array
        /// </summary>
        [JsonProperty("packages")]
        public AccountPlanPackageType[] Packages { get; private set; }

    }
}
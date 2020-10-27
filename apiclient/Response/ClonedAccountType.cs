using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The cloned account info.
    /// </summary>
    public class ClonedAccountType
    {
        /// <summary>
        /// The account's ID.
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; private set; }

        /// <summary>
        /// The account's name.
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; private set; }

        /// <summary>
        /// The account's email.
        /// </summary>
        [JsonProperty("account_email")]
        public string AccountEmail { get; private set; }

        /// <summary>
        /// The account activation flag.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; private set; }

        /// <summary>
        /// The account API key.
        /// </summary>
        [JsonProperty("api_key")]
        public string ApiKey { get; private set; }

        /// <summary>
        /// The cloned users.
        /// </summary>
        [JsonProperty("users")]
        public ClonedUserType[] Users { get; private set; }

        /// <summary>
        /// The cloned scenarios.
        /// </summary>
        [JsonProperty("scenarios")]
        public ClonedScenarioType[] Scenarios { get; private set; }

        /// <summary>
        /// The cloned applications.
        /// </summary>
        [JsonProperty("applications")]
        public ClonedApplicationType[] Applications { get; private set; }

        /// <summary>
        /// The cloned ACD queues.
        /// </summary>
        [JsonProperty("acd_queues")]
        public ClonedACDQueueType[] AcdQueues { get; private set; }

        /// <summary>
        /// The cloned ACD skills.
        /// </summary>
        [JsonProperty("acd_skills")]
        public ClonedACDSkillType[] AcdSkills { get; private set; }

        /// <summary>
        /// The cloned admin roles.
        /// </summary>
        [JsonProperty("admin_roles")]
        public ClonedAdminRoleType[] AdminRoles { get; private set; }

        /// <summary>
        /// The cloned admin users.
        /// </summary>
        [JsonProperty("admin_users")]
        public ClonedAdminUserType[] AdminUsers { get; private set; }

    }
}
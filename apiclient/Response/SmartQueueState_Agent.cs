using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// SmartQueueState.sq_agents item
    /// </summary>
    public class SmartQueueState_Agent
    {
        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; private set; }

        /// <summary>
        /// The user name.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; private set; }

        /// <summary>
        /// The display user name.
        /// </summary>
        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; private set; }

        /// <summary>
        /// Agent skills.
        /// </summary>
        [JsonProperty("sq_skills")]
        public SmartQueueAgent_Skill[] SqSkills { get; private set; }

        /// <summary>
        /// Agent status info.
        /// </summary>
        [JsonProperty("sq_statuses")]
        public SmartQueueState_Agent_Status SqStatuses { get; private set; }

    }
}
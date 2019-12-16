using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetUsersRequest : BaseRequest
    {
        /// <summary>
        /// The application ID to filter.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name part to filter.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The skill ID to filter.
        /// </summary>
        [JsonProperty("skill_id")]
        public long? SkillId { get; set; }

        /// <summary>
        /// The excluded skill ID to filter.
        /// </summary>
        [JsonProperty("excluded_skill_id")]
        public long? ExcludedSkillId { get; set; }

        /// <summary>
        /// The ACD queue ID to filter.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public long? AcdQueueId { get; set; }

        /// <summary>
        /// The excluded ACD queue ID to filter.
        /// </summary>
        [JsonProperty("excluded_acd_queue_id")]
        public long? ExcludedAcdQueueId { get; set; }

        /// <summary>
        /// The user ID to filter.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// The user name part to filter.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// The user active flag to filter.
        /// </summary>
        [JsonProperty("user_active")]
        public bool? UserActive { get; set; }

        /// <summary>
        /// The user display name part to filter.
        /// </summary>
        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// Set true to get the bound skills.
        /// </summary>
        [JsonProperty("with_skills")]
        public bool? WithSkills { get; set; }

        /// <summary>
        /// Set true to get the bound queues.
        /// </summary>
        [JsonProperty("with_queues")]
        public bool? WithQueues { get; set; }

        /// <summary>
        /// The ACD status list separated by the ';' symbol to filter. The
        /// following values are possible: OFFLINE, ONLINE, READY, BANNED,
        /// IN_SERVICE, AFTER_SERVICE, TIMEOUT, DND.
        /// </summary>
        [JsonProperty("acd_status")]
        public Argument<string> AcdStatus { get; set; }

        /// <summary>
        /// The skill to show in the 'skills' field output.
        /// </summary>
        [JsonProperty("showing_skill_id")]
        public long? ShowingSkillId { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// The following values are available: 'user_id', 'user_name' and
        /// 'user_display_name'.
        /// </summary>
        [JsonProperty("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Set true to get the user live balance.
        /// </summary>
        [JsonProperty("return_live_balance")]
        public bool? ReturnLiveBalance { get; set; }

    }
}
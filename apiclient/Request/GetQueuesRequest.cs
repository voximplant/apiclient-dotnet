using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetQueuesRequest : BaseRequest
    {
        /// <summary>
        /// The ACD queue ID to filter.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public long? AcdQueueId { get; set; }

        /// <summary>
        /// The ACD queue name part to filter.
        /// </summary>
        [JsonProperty("acd_queue_name")]
        public string AcdQueueName { get; set; }

        /// <summary>
        /// The application ID to filter.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

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
        /// Set true to get the bound skills.
        /// </summary>
        [JsonProperty("with_skills")]
        public bool? WithSkills { get; set; }

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

    }
}
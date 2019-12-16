using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class BindSkillRequest : BaseRequest
    {
        /// <summary>
        /// The skill ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("skill_id")]
        public Argument<long> SkillId { get; set; }

        /// <summary>
        /// Can be used instead of <b>skill_id</b>. The skill name list separated
        /// by the ';' symbol.
        /// </summary>
        [JsonProperty("skill_name")]
        public Argument<string> SkillName { get; set; }

        /// <summary>
        /// The user ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("user_id")]
        public Argument<long> UserId { get; set; }

        /// <summary>
        /// The user name that can be used instead of <b>user_id</b>. The user
        /// name list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("user_name")]
        public Argument<string> UserName { get; set; }

        /// <summary>
        /// The ACD queue ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public Argument<long> AcdQueueId { get; set; }

        /// <summary>
        /// The ACD queue name that can be used instead of <b>acd_queue_id</b>.
        /// The ACD queue name list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("acd_queue_name")]
        public Argument<string> AcdQueueName { get; set; }

        /// <summary>
        /// The application ID. It is required if the <b>user_name</b> is
        /// specified.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name that can be used instead of
        /// <b>application_id</b>.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Bind or unbind?
        /// </summary>
        [JsonProperty("bind")]
        public bool? Bind { get; set; }

    }
}
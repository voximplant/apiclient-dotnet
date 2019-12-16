using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetRuleInfoRequest : BaseRequest
    {
        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; set; }

        /// <summary>
        /// The new rule name. The length must be less than 100
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// The new rule pattern regex. The length must be less than 64 KB.
        /// </summary>
        [JsonProperty("rule_pattern")]
        public string RulePattern { get; set; }

        /// <summary>
        /// The new exclude pattern regex. The length must be less than 64 KB.
        /// </summary>
        [JsonProperty("rule_pattern_exclude")]
        public string RulePatternExclude { get; set; }

        /// <summary>
        /// Is video conference required?
        /// </summary>
        [JsonProperty("video_conference")]
        public bool? VideoConference { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetRules] function result item.
    /// </summary>
    public class RuleInfoType
    {
        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; private set; }

        /// <summary>
        /// The application ID.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; private set; }

        /// <summary>
        /// The rule name.
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; private set; }

        /// <summary>
        /// The rule pattern regex.
        /// </summary>
        [JsonProperty("rule_pattern")]
        public string RulePattern { get; private set; }

        /// <summary>
        /// The rule pattern exlude regex.
        /// </summary>
        [JsonProperty("rule_pattern_exclude")]
        public string RulePatternExclude { get; private set; }

        /// <summary>
        /// Is video conference required?
        /// </summary>
        [JsonProperty("video_conference")]
        public bool? VideoConference { get; private set; }

        /// <summary>
        /// The bound scenarios.
        /// </summary>
        [JsonProperty("scenarios")]
        public IReadOnlyList<ScenarioInfoType> Scenarios { get; private set; }

        /// <summary>
        /// The rule editing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("modified")]
        public DateTime? Modified { get; private set; }

    }
}
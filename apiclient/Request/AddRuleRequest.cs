using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddRuleRequest : BaseRequest
    {
        /// <summary>
        /// The application ID.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name, can be used instead of <b>application_id</b>.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The rule name. The length must be less than 100
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// The rule pattern regex. The length must be less than 64 KB.
        /// </summary>
        [JsonProperty("rule_pattern")]
        public string RulePattern { get; set; }

        /// <summary>
        /// The exclude pattern regex. The length must be less than 64 KB.
        /// </summary>
        [JsonProperty("rule_pattern_exclude")]
        public string RulePatternExclude { get; set; }

        /// <summary>
        /// Is video conference required?
        /// </summary>
        [JsonProperty("video_conference")]
        public bool? VideoConference { get; set; }

        /// <summary>
        /// The scenario ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("scenario_id")]
        public Argument<long> ScenarioId { get; set; }

        /// <summary>
        /// Can be used instead of <b>scenario_id</b>. The scenario name list
        /// separated by the ';' symbol.
        /// </summary>
        [JsonProperty("scenario_name")]
        public Argument<string> ScenarioName { get; set; }

    }
}
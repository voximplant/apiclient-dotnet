using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddScenarioRequest : BaseRequest
    {
        /// <summary>
        /// The scenario name. The length must be less than 30
        /// </summary>
        [JsonProperty("scenario_name")]
        public string ScenarioName { get; set; }

        /// <summary>
        /// The scenario text. The length must be less than 128 KB.
        /// </summary>
        [JsonProperty("scenario_script")]
        public string ScenarioScript { get; set; }

        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; set; }

        /// <summary>
        /// The rule name that can be used instead of <b>rule_id</b>.
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// Is the existing scenario rewrite?
        /// </summary>
        [JsonProperty("rewrite")]
        public bool? Rewrite { get; set; }

    }
}
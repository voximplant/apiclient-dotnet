using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class ReorderScenariosRequest : BaseRequest
    {
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
        /// The scenario ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("scenario_id")]
        public Argument<long> ScenarioId { get; set; }

    }
}
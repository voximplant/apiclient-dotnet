using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The cloned rule info.
    /// </summary>
    public class ClonedRuleType
    {
        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("rule_id")]
        public long RuleId { get; private set; }

        /// <summary>
        /// The rule name.
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; private set; }

    }
}
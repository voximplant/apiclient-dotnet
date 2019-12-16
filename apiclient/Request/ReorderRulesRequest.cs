using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class ReorderRulesRequest : BaseRequest
    {
        /// <summary>
        /// The rule ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("rule_id")]
        public Argument<long> RuleId { get; set; }

    }
}
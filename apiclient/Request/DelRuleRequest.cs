using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelRuleRequest : BaseRequest
    {
        /// <summary>
        /// The rule ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("rule_id")]
        public Argument<long> RuleId { get; set; }

        /// <summary>
        /// Can be used instead of <b>rule_id</b>. The rule name list separated
        /// by the ';' symbol.
        /// </summary>
        [JsonProperty("rule_name")]
        public Argument<string> RuleName { get; set; }

        /// <summary>
        /// The application ID list separated by the ';' symbol or the 'all'
        /// value.
        /// </summary>
        [JsonProperty("application_id")]
        public Argument<long> ApplicationId { get; set; }

        /// <summary>
        /// Can be used instead of <b>application_id</b>. The application name
        /// list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("application_name")]
        public Argument<string> ApplicationName { get; set; }

    }
}
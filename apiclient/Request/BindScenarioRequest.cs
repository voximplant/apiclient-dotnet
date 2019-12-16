using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class BindScenarioRequest : BaseRequest
    {
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
        /// The application ID.
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
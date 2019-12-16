using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelScenarioRequest : BaseRequest
    {
        /// <summary>
        /// The scenario ID list separated by the ';' symbol or the 'all' value.
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
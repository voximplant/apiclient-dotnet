using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetScenarioInfoRequest : BaseRequest
    {
        /// <summary>
        /// The scenario ID.
        /// </summary>
        [JsonProperty("scenario_id")]
        public long? ScenarioId { get; set; }

        /// <summary>
        /// The name of the scenario to edit, can be used instead of
        /// <b>scenario_id</b>.
        /// </summary>
        [JsonProperty("required_scenario_name")]
        public string RequiredScenarioName { get; set; }

        /// <summary>
        /// The new scenario name. The length must be less than 30
        /// </summary>
        [JsonProperty("scenario_name")]
        public string ScenarioName { get; set; }

        /// <summary>
        /// The new scenario text. The length must be less than 128 KB.
        /// </summary>
        [JsonProperty("scenario_script")]
        public string ScenarioScript { get; set; }

    }
}
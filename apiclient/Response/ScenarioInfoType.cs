using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetScenarios] function result.
    /// </summary>
    public class ScenarioInfoType
    {
        /// <summary>
        /// The scenario ID.
        /// </summary>
        [JsonProperty("scenario_id")]
        public long ScenarioId { get; private set; }

        /// <summary>
        /// The scenario name.
        /// </summary>
        [JsonProperty("scenario_name")]
        public string ScenarioName { get; private set; }

        /// <summary>
        /// The scenario text.
        /// </summary>
        [JsonProperty("scenario_script")]
        public string ScenarioScript { get; private set; }

        /// <summary>
        /// The scenario editing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("modified")]
        public DateTime Modified { get; private set; }

        /// <summary>
        /// 'True' if the scenario belongs to the parent account, 'false' if the scenario belongs to the current account.
        /// </summary>
        [JsonProperty("parent")]
        public bool Parent { get; private set; }

    }
}
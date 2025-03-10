using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The cloned scenario info.
    /// </summary>
    public class ClonedScenarioType
    {
        /// <summary>
        /// The scenario ID
        /// </summary>
        [JsonProperty("scenario_id")]
        public long ScenarioId { get; private set; }

        /// <summary>
        /// The scenario name
        /// </summary>
        [JsonProperty("scenario_name")]
        public string ScenarioName { get; private set; }

    }
}
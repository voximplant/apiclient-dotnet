using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetScenariosRequest : BaseRequest
    {
        /// <summary>
        /// The scenario ID to filter
        /// </summary>
        [JsonProperty("scenario_id")]
        public long? ScenarioId { get; set; }

        /// <summary>
        /// The scenario name to filter. Can be used instead of
        /// <b>scenario_id</b>. All scenarios containing this param in their
        /// names will be returned. The parameter is case insensitive.
        /// </summary>
        [JsonProperty("scenario_name")]
        public string ScenarioName { get; set; }

        /// <summary>
        /// Set true to get the scenario text. You must specify the 'scenario_id'
        /// too!
        /// </summary>
        [JsonProperty("with_script")]
        public bool? WithScript { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

    }
}
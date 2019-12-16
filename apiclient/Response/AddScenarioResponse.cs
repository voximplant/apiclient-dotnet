using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddScenarioResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long? Result { get; private set; }

        /// <summary>
        /// The new scenario ID.
        /// </summary>
        [JsonProperty("scenario_id")]
        public long? ScenarioId { get; private set; }

    }
}
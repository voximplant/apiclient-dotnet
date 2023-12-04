using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetScenariosResponse : BaseResponse
    {

        [JsonProperty("result")]
        public ScenarioInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found scenario count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned scenario count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
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

        /// <summary>
        /// ID of the scenario's application
        /// </summary>
        [JsonProperty("application_id")]
        public long ApplicationId { get; private set; }

        /// <summary>
        /// Name of the scenario's application
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; private set; }

    }
}
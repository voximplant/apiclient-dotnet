using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetApplicationsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<ApplicationInfoType> Result { get; private set; }

        /// <summary>
        /// The total found application count.
        /// </summary>
        [JsonProperty("total_count")]
        public long? TotalCount { get; private set; }

        /// <summary>
        /// The returned application count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; private set; }

    }
}
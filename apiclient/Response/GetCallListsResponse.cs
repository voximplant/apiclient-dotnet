using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetCallListsResponse : BaseResponse
    {
        /// <summary>
        /// Array of lists
        /// </summary>
        [JsonProperty("result")]
        public CallListType[] Result { get; private set; }

        /// <summary>
        /// The returned call list count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

        /// <summary>
        /// The total found call list count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

    }
}
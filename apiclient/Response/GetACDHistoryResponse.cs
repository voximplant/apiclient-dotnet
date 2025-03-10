using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetACDHistoryResponse : BaseResponse
    {

        [JsonProperty("result")]
        public ACDSessionInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found ACD session count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned ACD session count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
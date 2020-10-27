using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetQueuesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public QueueInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found queue count.
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned queue count.
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
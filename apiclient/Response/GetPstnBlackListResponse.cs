using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetPstnBlackListResponse : BaseResponse
    {

        [JsonProperty("result")]
        public PstnBlackListInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found phone numbers count.
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned phone numbers count.
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
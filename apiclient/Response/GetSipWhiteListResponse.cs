using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetSipWhiteListResponse : BaseResponse
    {

        [JsonProperty("result")]
        public SipWhiteListInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found networks count.
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned networks count.
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
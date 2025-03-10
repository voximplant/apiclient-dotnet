using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetAuthorizedAccountIPsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public AuthorizedAccountIPType[] Result { get; private set; }

        /// <summary>
        /// The total found network count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned network count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
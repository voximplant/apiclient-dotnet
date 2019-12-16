using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetCallerIDsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<CallerIDInfoType> Result { get; private set; }

        /// <summary>
        /// The total found record count.
        /// </summary>
        [JsonProperty("total_count")]
        public long? TotalCount { get; private set; }

        /// <summary>
        /// The returned record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; private set; }

    }
}
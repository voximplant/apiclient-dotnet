using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetRulesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<RuleInfoType> Result { get; private set; }

        /// <summary>
        /// The total found rule count.
        /// </summary>
        [JsonProperty("total_count")]
        public long? TotalCount { get; private set; }

        /// <summary>
        /// The returned rule count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; private set; }

    }
}
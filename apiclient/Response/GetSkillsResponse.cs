using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetSkillsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<SkillInfoType> Result { get; private set; }

        /// <summary>
        /// The total found skill count.
        /// </summary>
        [JsonProperty("total_count")]
        public long? TotalCount { get; private set; }

        /// <summary>
        /// The returned skill count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; private set; }

    }
}
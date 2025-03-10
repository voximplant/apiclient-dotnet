using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetCallHistoryResponse : BaseResponse
    {
        /// <summary>
        /// The CallSessionInfoType records
        /// </summary>
        [JsonProperty("result")]
        public CallSessionInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found call session count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned call session count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

        /// <summary>
        /// The used timezone
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; private set; }

    }
}
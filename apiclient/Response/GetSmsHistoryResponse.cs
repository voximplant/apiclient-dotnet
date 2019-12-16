using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetSmsHistoryResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<SmsHistoryType> Result { get; private set; }

        /// <summary>
        /// Total number of distinct messages fetched.
        /// </summary>
        [JsonProperty("total_count")]
        public long? TotalCount { get; private set; }

    }
}
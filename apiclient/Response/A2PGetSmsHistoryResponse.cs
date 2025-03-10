using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class A2PGetSmsHistoryResponse : BaseResponse
    {

        [JsonProperty("result")]
        public A2PSmsHistoryType[] Result { get; private set; }

        /// <summary>
        /// Total number of messages matching the query parameters
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

    }
}
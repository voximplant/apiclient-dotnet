using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetChildrenAccountsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public AccountInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found user count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned user count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
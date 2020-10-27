using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetUsersResponse : BaseResponse
    {
        /// <summary>
        /// The UserInfoType records.
        /// </summary>
        [JsonProperty("result")]
        public UserInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found user count.
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned user count.
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
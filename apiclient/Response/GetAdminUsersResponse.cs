using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetAdminUsersResponse : BaseResponse
    {

        [JsonProperty("result")]
        public AdminUserType[] Result { get; private set; }

        /// <summary>
        /// The total found admin user count.
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned admin user count.
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
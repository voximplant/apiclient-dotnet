using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetAdminRolesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public AdminRoleType[] Result { get; private set; }

        /// <summary>
        /// The total found admin role count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned admin role count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
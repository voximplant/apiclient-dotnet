using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetAuditLogResponse : BaseResponse
    {

        [JsonProperty("result")]
        public AuditLogInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found item count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned item count
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
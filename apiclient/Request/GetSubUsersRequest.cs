using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetSubUsersRequest : BaseRequest
    {
        /// <summary>
        /// The subuser's ID.
        /// </summary>
        [JsonProperty("subuser_id")]
        public long? SubuserId { get; set; }

        /// <summary>
        /// Show subuser's roles
        /// </summary>
        [JsonProperty("with_roles")]
        public bool? WithRoles { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

    }
}
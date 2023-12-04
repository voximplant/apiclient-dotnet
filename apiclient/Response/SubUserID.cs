using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [AddSubUser] function result.
    /// </summary>
    public class SubUserID
    {
        /// <summary>
        /// The subuser ID
        /// </summary>
        [JsonProperty("subuser_id")]
        public long SubuserId { get; private set; }

    }
}
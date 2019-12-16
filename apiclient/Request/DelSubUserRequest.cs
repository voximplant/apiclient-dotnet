using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelSubUserRequest : BaseRequest
    {
        /// <summary>
        /// The subuser's ID.
        /// </summary>
        [JsonProperty("subuser_id")]
        public long? SubuserId { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class CheckAuthorizedAccountIPResponse : BaseResponse
    {
        /// <summary>
        /// Whether the IP is allowed
        /// </summary>
        [JsonProperty("result")]
        public bool Result { get; private set; }

        /// <summary>
        /// The matched authorized IP or network (if found)
        /// </summary>
        [JsonProperty("authorized_ip")]
        public string AuthorizedIp { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class CheckAuthorizedAccountIPRequest : BaseRequest
    {
        /// <summary>
        /// The IP4 to test.
        /// </summary>
        [JsonProperty("authorized_ip")]
        public string AuthorizedIp { get; set; }

    }
}
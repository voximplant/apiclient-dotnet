using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddAuthorizedAccountIPRequest : BaseRequest
    {
        /// <summary>
        /// The authorized IP4 or network.
        /// </summary>
        [JsonProperty("authorized_ip")]
        public string AuthorizedIp { get; set; }

        /// <summary>
        /// Set false to add the IP to the blacklist.
        /// </summary>
        [JsonProperty("allowed")]
        public bool? Allowed { get; set; }

    }
}
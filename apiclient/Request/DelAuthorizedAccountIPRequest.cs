using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelAuthorizedAccountIPRequest : BaseRequest
    {
        /// <summary>
        /// The authorized IP4 or network to remove. Set to 'all' to remove all
        /// items.
        /// </summary>
        [JsonProperty("authorized_ip")]
        public string AuthorizedIp { get; set; }

        /// <summary>
        /// Can be used instead of <b>autharized_ip</b>. Specify the parameter to
        /// remove the networks that contains the particular IP4.
        /// </summary>
        [JsonProperty("contains_ip")]
        public string ContainsIp { get; set; }

        /// <summary>
        /// Set true to remove the network from the white list. Set false to
        /// remove the network from the black list. Omit the parameter to remove
        /// the network from all lists.
        /// </summary>
        [JsonProperty("allowed")]
        public bool? Allowed { get; set; }

    }
}
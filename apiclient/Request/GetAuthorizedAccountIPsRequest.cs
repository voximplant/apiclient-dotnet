using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetAuthorizedAccountIPsRequest : BaseRequest
    {
        /// <summary>
        /// The authorized IP4 or network to filter.
        /// </summary>
        [JsonProperty("authorized_ip")]
        public string AuthorizedIp { get; set; }

        /// <summary>
        /// The allowed flag to filter.
        /// </summary>
        [JsonProperty("allowed")]
        public bool? Allowed { get; set; }

        /// <summary>
        /// Specify the parameter to filter the networks that contains the
        /// particular IP4.
        /// </summary>
        [JsonProperty("contains_ip")]
        public string ContainsIp { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

    }
}
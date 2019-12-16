using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetAuthorizedAccountIPs] function result.
    /// </summary>
    public class AuthorizedAccountIPType
    {
        /// <summary>
        /// The authorized IP4 or network.
        /// </summary>
        [JsonProperty("authorized_ip")]
        public string AuthorizedIp { get; private set; }

        /// <summary>
        /// The allowed flag (true - whitelist, false - blacklist).
        /// </summary>
        [JsonProperty("allowed")]
        public bool? Allowed { get; private set; }

        /// <summary>
        /// The item creating UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("created")]
        public DateTime? Created { get; private set; }

    }
}
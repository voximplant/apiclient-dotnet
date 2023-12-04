using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The account callbacks body. See <a href='/docs/guides/managementapi/callbacks'>this article</a> for details.
    /// </summary>
    public class AccountCallbacks
    {
        /// <summary>
        /// The account callback array
        /// </summary>
        [JsonProperty("callbacks")]
        public AccountCallback[] Callbacks { get; private set; }

    }
}
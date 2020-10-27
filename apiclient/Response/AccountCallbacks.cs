using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The HTTP account callbacks body. See <a href='/docs/howtos/integration/httpapi/callbacks'>this article</a> for details.
    /// </summary>
    public class AccountCallbacks
    {
        /// <summary>
        /// The account callback array.
        /// </summary>
        [JsonProperty("callbacks")]
        public AccountCallback[] Callbacks { get; private set; }

    }
}
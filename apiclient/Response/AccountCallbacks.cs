using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The HTTP account callbacks body. See <a
    /// href='//voximplant.com/blog/http-api-callbacks'>this article</a> for
    /// details.
    /// </summary>
    public class AccountCallbacks
    {
        /// <summary>
        /// The account callback array.
        /// </summary>
        [JsonProperty("callbacks")]
        public IReadOnlyList<AccountCallback> Callbacks { get; private set; }

    }
}
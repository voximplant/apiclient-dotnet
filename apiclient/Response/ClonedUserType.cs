using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The cloned user info.
    /// </summary>
    public class ClonedUserType
    {
        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; private set; }

        /// <summary>
        /// The user name.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The queue users info.
    /// </summary>
    public class QueueUsers
    {
        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; private set; }

    }
}
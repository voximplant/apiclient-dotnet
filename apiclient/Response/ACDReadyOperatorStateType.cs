using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The ready operator state.
    /// </summary>
    public class ACDReadyOperatorStateType
    {
        /// <summary>
        /// The user ID of the operator.
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; private set; }

        /// <summary>
        /// The user name of the operator.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; private set; }

        /// <summary>
        /// The display user name of the operator.
        /// </summary>
        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; private set; }

        /// <summary>
        /// The idle duration in seconds. The minimum of the duration after the last hangup and the duration after the operator status changing to READY.
        /// </summary>
        [JsonProperty("idle_duration")]
        public long IdleDuration { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The after service operator state.
    /// </summary>
    public class ACDAfterServiceOperatorStateType
    {
        /// <summary>
        /// The user ID of the operator.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; private set; }

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
        /// The operator <a
        /// href='//voximplant.com/docs/references/websdk/voximplant/operatoracdstatuses'>status
        /// string</a>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }

    }
}
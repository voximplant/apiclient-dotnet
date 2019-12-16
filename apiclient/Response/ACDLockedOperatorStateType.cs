using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The locked operator state.
    /// </summary>
    public class ACDLockedOperatorStateType
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
        /// The UTC time when the operator becomes unavailable in 24-h format:
        /// YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("unreached")]
        public DateTime? Unreached { get; private set; }

        /// <summary>
        /// The operator locks.
        /// </summary>
        [JsonProperty("locks")]
        public IReadOnlyList<ACDLock> Locks { get; private set; }

        /// <summary>
        /// The ACD operator calls.
        /// </summary>
        [JsonProperty("acd_calls")]
        public IReadOnlyList<ACDOperatorCall> AcdCalls { get; private set; }

        /// <summary>
        /// The operator <a
        /// href='//voximplant.com/docs/references/websdk/voximplant/operatoracdstatuses'>status
        /// string</a>. 'BANNED' string indicates temporarily <a
        /// href='//voximplant.com/blog/step-by-step-call-center-tutorial-part-7'>banned
        /// operators</a>. The following values are possible: READY, BANNED.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }

    }
}
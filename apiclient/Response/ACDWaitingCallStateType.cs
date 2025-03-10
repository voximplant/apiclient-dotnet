using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The waiting call state.
    /// </summary>
    public class ACDWaitingCallStateType
    {
        /// <summary>
        /// The user ID of the operator to try to service the request
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; private set; }

        /// <summary>
        /// The user name of the operator
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; private set; }

        /// <summary>
        /// The display user name of the operator
        /// </summary>
        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; private set; }

        /// <summary>
        /// The request priority
        /// </summary>
        [JsonProperty("priority")]
        public long Priority { get; private set; }

        /// <summary>
        /// The client callerid
        /// </summary>
        [JsonProperty("callerid")]
        public string Callerid { get; private set; }

        /// <summary>
        /// The begin time of the request in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("begin_time")]
        public DateTime BeginTime { get; private set; }

        /// <summary>
        /// The waiting time in seconds
        /// </summary>
        [JsonProperty("waiting_time")]
        public long WaitingTime { get; private set; }

        /// <summary>
        /// The predicted minutes left to start servicing
        /// </summary>
        [JsonProperty("minutes_to_submit")]
        public long MinutesToSubmit { get; private set; }

        /// <summary>
        /// The ACD session history ID of the request
        /// </summary>
        [JsonProperty("acd_session_history_id")]
        public long AcdSessionHistoryId { get; private set; }

    }
}
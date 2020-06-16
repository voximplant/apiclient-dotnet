using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Information about call list's configurations.
    /// </summary>
    public class CallListType
    {
        /// <summary>
        /// The list ID.
        /// </summary>
        [JsonProperty("list_id")]
        public long? ListId { get; private set; }

        /// <summary>
        /// The list name.
        /// </summary>
        [JsonProperty("list_name")]
        public string ListName { get; private set; }

        /// <summary>
        /// The priority of call list.
        /// </summary>
        [JsonProperty("priority")]
        public long? Priority { get; private set; }

        /// <summary>
        /// The rule id.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; private set; }

        /// <summary>
        /// The maximum number of simultaneous tasks.
        /// </summary>
        [JsonProperty("max_simultaneous")]
        public long? MaxSimultaneous { get; private set; }

        /// <summary>
        /// The number of task attempts run, which failed to call.
        /// </summary>
        [JsonProperty("num_attempts")]
        public long? NumAttempts { get; private set; }

        /// <summary>
        /// The date of submitted the list in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("dt_submit")]
        public DateTime? DtSubmit { get; private set; }

        /// <summary>
        /// The completion date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("dt_complete")]
        public DateTime? DtComplete { get; private set; }

        /// <summary>
        /// The interval between attempts in seconds.
        /// </summary>
        [JsonProperty("interval_seconds")]
        public long? IntervalSeconds { get; private set; }

        /// <summary>
        /// The status name. The possible values are: __In progress__,
        /// __Completed__, __Canceled__.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }

    }
}
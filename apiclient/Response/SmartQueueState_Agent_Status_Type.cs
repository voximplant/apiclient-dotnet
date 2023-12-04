using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The current operator's status type. Refer to <a href='https://voximplant.com/docs/guides/smartqueue/howto#set-up-an-operator's-workspace'>this guide</a> to read more about SmartQueue operator statuses
    /// </summary>
    public class SmartQueueState_Agent_Status_Type
    {
        /// <summary>
        /// The status name
        /// </summary>
        [JsonProperty("sq_status_name")]
        public string SqStatusName { get; private set; }

        /// <summary>
        /// Time in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("from_date")]
        public DateTime FromDate { get; private set; }

    }
}
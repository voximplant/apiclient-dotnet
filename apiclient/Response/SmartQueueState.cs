using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetSQState] function result.
    /// </summary>
    public class SmartQueueState
    {
        /// <summary>
        /// The SmartQueue ID
        /// </summary>
        [JsonProperty("sq_queue_id")]
        public long SqQueueId { get; private set; }

        /// <summary>
        /// The SmartQueue name
        /// </summary>
        [JsonProperty("sq_queue_name")]
        public string SqQueueName { get; private set; }

        /// <summary>
        /// The list of logged-in agents with their skills and statuses
        /// </summary>
        [JsonProperty("sq_agents")]
        public SmartQueueState_Agent[] SqAgents { get; private set; }

        /// <summary>
        /// The list of tasks
        /// </summary>
        [JsonProperty("tasks")]
        public SmartQueueState_Task[] Tasks { get; private set; }

    }
}
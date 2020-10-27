using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// SmartQueueState.tasks item
    /// </summary>
    public class SmartQueueState_Task
    {
        /// <summary>
        /// The task type: CALL, IM.
        /// </summary>
        [JsonProperty("task_type")]
        public string TaskType { get; private set; }

        /// <summary>
        /// The task status: IN_QUEUE, DISTRIBUTED, IN_PROCESSING.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }

        /// <summary>
        /// Selected agent.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; private set; }

        /// <summary>
        /// Task skills.
        /// </summary>
        [JsonProperty("sq_skills")]
        public SmartQueueTask_Skill[] SqSkills { get; private set; }

        /// <summary>
        /// Waiting time in ms.
        /// </summary>
        [JsonProperty("waiting_time")]
        public long WaitingTime { get; private set; }

        /// <summary>
        /// Processing time in ms.
        /// </summary>
        [JsonProperty("processing_time")]
        public long ProcessingTime { get; private set; }

        /// <summary>
        /// Custom data.
        /// </summary>
        [JsonProperty("custom_data")]
        public Object CustomData { get; private set; }

    }
}
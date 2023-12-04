using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetQueues] function result item.
    /// </summary>
    public class QueueInfoType
    {
        /// <summary>
        /// The ACD queue ID
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public long AcdQueueId { get; private set; }

        /// <summary>
        /// The queue name
        /// </summary>
        [JsonProperty("acd_queue_name")]
        public string AcdQueueName { get; private set; }

        /// <summary>
        /// The application ID
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; private set; }

        /// <summary>
        /// The integer queue priority. The highest priority is 0
        /// </summary>
        [JsonProperty("acd_queue_priority")]
        public long AcdQueuePriority { get; private set; }

        /// <summary>
        /// The value in the range of [0.5 ... 1.0]. The value 1.0 means the service probability 100% in challenge with a lower priority queue
        /// </summary>
        [JsonProperty("service_probability")]
        public long ServiceProbability { get; private set; }

        /// <summary>
        /// Set false to disable the auto binding of operators to a queue by skills comparing
        /// </summary>
        [JsonProperty("auto_binding")]
        public bool AutoBinding { get; private set; }

        /// <summary>
        /// The maximum predicted waiting time in minutes. When a call is going to be enqueued to the queue, its predicted waiting time should be less or equal to the maximum predicted waiting time; otherwise, a call would be rejected
        /// </summary>
        [JsonProperty("max_waiting_time")]
        public long? MaxWaitingTime { get; private set; }

        /// <summary>
        /// The maximum number of calls that can be enqueued into this queue
        /// </summary>
        [JsonProperty("max_queue_size")]
        public long? MaxQueueSize { get; private set; }

        /// <summary>
        /// The average service time in seconds. Specify the parameter to correct or initialize the waiting time prediction
        /// </summary>
        [JsonProperty("average_service_time")]
        public long? AverageServiceTime { get; private set; }

        /// <summary>
        /// The ACD queue creating UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; private set; }

        /// <summary>
        /// The ACD queue editing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("modified")]
        public DateTime Modified { get; private set; }

        /// <summary>
        /// The ACD queue deleting UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("deleted")]
        public DateTime? Deleted { get; private set; }

        /// <summary>
        /// The queue users info
        /// </summary>
        [JsonProperty("users")]
        public QueueUsers[] Users { get; private set; }

        /// <summary>
        /// The queue skills info
        /// </summary>
        [JsonProperty("skills")]
        public QueueSkills[] Skills { get; private set; }

        /// <summary>
        /// The service level thresholds in seconds
        /// </summary>
        [JsonProperty("sl_thresholds")]
        public long[] SlThresholds { get; private set; }

        /// <summary>
        /// Number of agents bound to the queue
        /// </summary>
        [JsonProperty("operatorcount")]
        public long? Operatorcount { get; private set; }

    }
}
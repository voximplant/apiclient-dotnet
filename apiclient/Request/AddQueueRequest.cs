using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddQueueRequest : BaseRequest
    {
        /// <summary>
        /// The application ID.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name that can be used instead of
        /// <b>application_id</b>.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The queue name. The length must be less than 100.
        /// </summary>
        [JsonProperty("acd_queue_name")]
        public string AcdQueueName { get; set; }

        /// <summary>
        /// The integer queue priority. The highest priority is 0.
        /// </summary>
        [JsonProperty("acd_queue_priority")]
        public long? AcdQueuePriority { get; set; }

        /// <summary>
        /// Set false to disable the auto binding of operators to a queue by
        /// skills comparing.
        /// </summary>
        [JsonProperty("auto_binding")]
        public bool? AutoBinding { get; set; }

        /// <summary>
        /// The value in the range of [0.5 ... 1.0]. The value 1.0 means the
        /// service probability 100% in challenge with a lower priority queue.
        /// </summary>
        [JsonProperty("service_probability")]
        public long? ServiceProbability { get; set; }

        /// <summary>
        /// The max queue size.
        /// </summary>
        [JsonProperty("max_queue_size")]
        public long? MaxQueueSize { get; set; }

        /// <summary>
        /// The max predicted waiting time in minutes. The client is rejected if
        /// the predicted waiting time is greater than the max predicted waiting
        /// time.
        /// </summary>
        [JsonProperty("max_waiting_time")]
        public long? MaxWaitingTime { get; set; }

        /// <summary>
        /// The average service time in seconds. Specify the parameter to correct
        /// or initialize the waiting time prediction.
        /// </summary>
        [JsonProperty("average_service_time")]
        public long? AverageServiceTime { get; set; }

    }
}
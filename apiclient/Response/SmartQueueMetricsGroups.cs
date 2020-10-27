using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [SmartQueueMetricsResult] details.
    /// </summary>
    public class SmartQueueMetricsGroups
    {
        /// <summary>
        /// The smart queue ID.
        /// </summary>
        [JsonProperty("sq_queue_id")]
        public long? SqQueueId { get; private set; }

        /// <summary>
        /// The smart queue name.
        /// </summary>
        [JsonProperty("sq_queue_name")]
        public string SqQueueName { get; private set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; private set; }

        /// <summary>
        /// The user name.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; private set; }

        /// <summary>
        /// The user display name.
        /// </summary>
        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; private set; }

        /// <summary>
        /// The group values.
        /// </summary>
        [JsonProperty("values")]
        public SmartQueueMetricsGroupsValues[] Values { get; private set; }

    }
}
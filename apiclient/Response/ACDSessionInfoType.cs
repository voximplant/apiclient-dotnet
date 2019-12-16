using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetACDHistory] function result item.
    /// </summary>
    public class ACDSessionInfoType
    {
        /// <summary>
        /// The ACD session history ID.
        /// </summary>
        [JsonProperty("acd_session_history_id")]
        public long? AcdSessionHistoryId { get; private set; }

        /// <summary>
        /// The ACD request ID. See the
        /// [ACDRequest.id()](https://voximplant.com/docs/references/voxengine/acd/acdrequest#id)
        /// VoxEngine method.
        /// </summary>
        [JsonProperty("acd_request_id")]
        public string AcdRequestId { get; private set; }

        /// <summary>
        /// The account ID.
        /// </summary>
        [JsonProperty("account_id")]
        public long? AccountId { get; private set; }

        /// <summary>
        /// The UTC start date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("begin_time")]
        public DateTime? BeginTime { get; private set; }

        /// <summary>
        /// The request priority.
        /// </summary>
        [JsonProperty("priority")]
        public long? Priority { get; private set; }

        /// <summary>
        /// The ACD queue ID.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public long? AcdQueueId { get; private set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; private set; }

        /// <summary>
        /// The waiting duration in seconds.
        /// </summary>
        [JsonProperty("waiting_duration")]
        public long? WaitingDuration { get; private set; }

        /// <summary>
        /// The conversation duration in seconds.
        /// </summary>
        [JsonProperty("in_service_duration")]
        public long? InServiceDuration { get; private set; }

        /// <summary>
        /// The after service duration in seconds.
        /// </summary>
        [JsonProperty("after_service_duration")]
        public long? AfterServiceDuration { get; private set; }

        /// <summary>
        /// The bound events.
        /// </summary>
        [JsonProperty("events")]
        public IReadOnlyList<ACDSessionEventInfoType> Events { get; private set; }

    }
}
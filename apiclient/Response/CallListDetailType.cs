using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Detailing job telephone calls
    /// </summary>
    public class CallListDetailType
    {
        /// <summary>
        /// The list ID.
        /// </summary>
        [JsonProperty("list_id")]
        public long? ListId { get; private set; }

        /// <summary>
        /// Data for transmission to the script
        /// </summary>
        [JsonProperty("custom_data")]
        public string CustomData { get; private set; }

        /// <summary>
        /// Time with which to start the job in 24-h format: HH:mm:ss
        /// </summary>
        [JsonProperty("start_execution_time")]
        public string StartExecutionTime { get; private set; }

        /// <summary>
        /// Time after which the task can not be performed in 24-h format:
        /// HH:mm:ss
        /// </summary>
        [JsonProperty("finish_execution_time")]
        public string FinishExecutionTime { get; private set; }

        /// <summary>
        /// Results of the task, if it was granted, or information about the
        /// runtime error.
        /// </summary>
        [JsonProperty("result_data")]
        public string ResultData { get; private set; }

        /// <summary>
        /// Date and time of the last attempt to perform a task.
        /// </summary>
        [JsonProperty("last_attempt")]
        public string LastAttempt { get; private set; }

        /// <summary>
        /// Number of remaining attempts.
        /// </summary>
        [JsonProperty("attempts_left")]
        public long? AttemptsLeft { get; private set; }

        /// <summary>
        /// The status ID. Available values: __0__ (status = New), __1__ (status
        /// = In progress), __2__ (status = Processed), __3__ (status = Error),
        /// __4__ (status = Cancelled).
        /// </summary>
        [JsonProperty("status_id")]
        public long? StatusId { get; private set; }

        /// <summary>
        /// The status name. Available values: __New__ (status_id = 0), __In
        /// progress__ (status_id = 1), __Processed__ (status_id = 2), __Error__
        /// (status_id = 3), __Cancelled__ (status_id = 4).
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }

    }
}
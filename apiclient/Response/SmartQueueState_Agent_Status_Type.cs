using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// SmartQueueState.sq_agents item
    /// </summary>
    public class SmartQueueState_Agent_Status_Type
    {
        /// <summary>
        /// The status name.
        /// </summary>
        [JsonProperty("sq_status_name")]
        public string SqStatusName { get; private set; }

        /// <summary>
        /// Time in 24-h format: YYYY-MM-DD HH:mm:ss.
        /// </summary>
        [JsonProperty("from_date")]
        public string FromDate { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// SmartQueueState.sq_agents item
    /// </summary>
    public class SmartQueueState_Agent_Status
    {
        /// <summary>
        /// The IM status info.
        /// </summary>
        [JsonProperty("IM")]
        public SmartQueueState_Agent_Status_Type IM { get; private set; }

        /// <summary>
        /// The CALL status info.
        /// </summary>
        [JsonProperty("CALL")]
        public SmartQueueState_Agent_Status_Type CALL { get; private set; }

    }
}
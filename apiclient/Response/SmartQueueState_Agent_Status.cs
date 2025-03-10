using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The current operator's status. Refer to <a href='https://voximplant.com/docs/guides/smartqueue/howto#set-up-an-operator's-workspace'>this guide</a> to read more about SmartQueue operator statuses
    /// </summary>
    public class SmartQueueState_Agent_Status
    {
        /// <summary>
        /// The IM status info
        /// </summary>
        [JsonProperty("IM")]
        public SmartQueueState_Agent_Status_Type IM { get; private set; }

        /// <summary>
        /// The CALL status info
        /// </summary>
        [JsonProperty("CALL")]
        public SmartQueueState_Agent_Status_Type CALL { get; private set; }

    }
}
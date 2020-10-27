using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetACDState] function result item.
    /// </summary>
    public class ACDStateType
    {
        /// <summary>
        /// The queues' states.
        /// </summary>
        [JsonProperty("acd_queues")]
        public ACDQueueStateType[] AcdQueues { get; private set; }

    }
}
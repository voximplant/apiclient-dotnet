using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The ACD queue state.
    /// </summary>
    public class ACDQueueStateType
    {
        /// <summary>
        /// The ACD queue ID
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public long? AcdQueueId { get; private set; }

        /// <summary>
        /// List of operators with the 'READY' state that can accept a call from
        /// this queue
        /// </summary>
        [JsonProperty("ready_operators")]
        public IReadOnlyList<ACDReadyOperatorStateType> ReadyOperators { get; private set; }

        /// <summary>
        /// Number of ready operators.
        /// </summary>
        [JsonProperty("ready_operators_count")]
        public long? ReadyOperatorsCount { get; private set; }

        /// <summary>
        /// List of operators with the 'READY' state that can't accept a call
        /// from this queue. Operator can't accept a call if they are temporarily
        /// banned or they are servicing a call right now
        /// </summary>
        [JsonProperty("locked_operators")]
        public IReadOnlyList<ACDLockedOperatorStateType> LockedOperators { get; private set; }

        /// <summary>
        /// Number of locked operators.
        /// </summary>
        [JsonProperty("locked_operators_count")]
        public long? LockedOperatorsCount { get; private set; }

        /// <summary>
        /// List of operators with the 'AFTER_SERVICE' state. This state is set
        /// right after a call is ended to indicate a call postprocessing.
        /// </summary>
        [JsonProperty("after_service_operators")]
        public IReadOnlyList<ACDAfterServiceOperatorStateType> AfterServiceOperators { get; private set; }

        /// <summary>
        /// Number of operators with the 'AFTER SERVICE' state.
        /// </summary>
        [JsonProperty("after_service_operator_count")]
        public long? AfterServiceOperatorCount { get; private set; }

        /// <summary>
        /// List of calls enqueued into this queue that are being serviced right
        /// now by operators
        /// </summary>
        [JsonProperty("servicing_calls")]
        public IReadOnlyList<ACDServicingCallStateType> ServicingCalls { get; private set; }

        /// <summary>
        /// List of calls enqueued into this queue that are not yet serviced by
        /// operators
        /// </summary>
        [JsonProperty("waiting_calls")]
        public IReadOnlyList<ACDWaitingCallStateType> WaitingCalls { get; private set; }

    }
}
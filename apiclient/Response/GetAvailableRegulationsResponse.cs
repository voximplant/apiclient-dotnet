using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetAvailableRegulationsResponse : BaseResponse
    {
        /// <summary>
        /// Whether the user has at least one regulation address which is appropriate for verification or the verification is not required. If result is false, the regulations address needs to be created
        /// </summary>
        [JsonProperty("result")]
        public bool Result { get; private set; }

        /// <summary>
        /// The available RegulationAddress records
        /// </summary>
        [JsonProperty("available_address")]
        public RegulationAddress[] AvailableAddress { get; private set; }

        /// <summary>
        /// The count of RegulationAddress in progress status
        /// </summary>
        [JsonProperty("count_in_progress")]
        public long CountInProgress { get; private set; }

    }
}
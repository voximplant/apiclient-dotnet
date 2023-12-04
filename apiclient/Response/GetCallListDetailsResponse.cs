using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetCallListDetailsResponse : BaseResponse
    {
        /// <summary>
        /// Array of tasks for the roll call
        /// </summary>
        [JsonProperty("result")]
        public CallListDetailType[] Result { get; private set; }

        /// <summary>
        /// The number of tasks
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddQueueResponse : BaseResponse
    {
        /// <summary>
        /// Returns 1 if the request has been completed successfully
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The ACD queue ID
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public long AcdQueueId { get; private set; }

    }
}
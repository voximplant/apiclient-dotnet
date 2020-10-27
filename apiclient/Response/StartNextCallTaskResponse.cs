using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class StartNextCallTaskResponse : BaseResponse
    {
        /// <summary>
        /// true
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The list id.
        /// </summary>
        [JsonProperty("list_id")]
        public long ListId { get; private set; }

    }
}
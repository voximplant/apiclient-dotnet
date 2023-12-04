using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class StopCallListProcessingResponse : BaseResponse
    {
        /// <summary>
        /// true
        /// </summary>
        [JsonProperty("result")]
        public bool Result { get; private set; }

        /// <summary>
        /// Result message
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; private set; }

    }
}
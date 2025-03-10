using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class RecoverCallListResponse : BaseResponse
    {
        /// <summary>
        /// true
        /// </summary>
        [JsonProperty("result")]
        public bool Result { get; private set; }

        /// <summary>
        /// Number restored tasks
        /// </summary>
        [JsonProperty("count_recovery")]
        public long CountRecovery { get; private set; }

    }
}
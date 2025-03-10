using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetZIPCodesResponse : BaseResponse
    {
        /// <summary>
        /// The ZipCode records
        /// </summary>
        [JsonProperty("result")]
        public ZipCode[] Result { get; private set; }

        /// <summary>
        /// The returned zip codes count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class DelAuthorizedAccountIPResponse : BaseResponse
    {
        /// <summary>
        /// The removed network count.
        /// </summary>
        [JsonProperty("result")]
        public long? Result { get; private set; }

    }
}
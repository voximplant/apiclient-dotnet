using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class SendSmsMessageResponse : BaseResponse
    {

        [JsonProperty("result")]
        public long? Result { get; private set; }

        /// <summary>
        /// The number of fragments to which the message divided.
        /// </summary>
        [JsonProperty("fragments_count")]
        public long? FragmentsCount { get; private set; }

    }
}
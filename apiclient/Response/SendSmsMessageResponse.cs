using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class SendSmsMessageResponse : BaseResponse
    {

        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// Message ID
        /// </summary>
        [JsonProperty("message_id")]
        public long MessageId { get; private set; }

        /// <summary>
        /// The number of fragments the message is divided into
        /// </summary>
        [JsonProperty("fragments_count")]
        public long FragmentsCount { get; private set; }

    }
}
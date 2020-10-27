using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class A2PSendSmsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public SmsTransaction[] Result { get; private set; }


        [JsonProperty("failed")]
        public FailedSms[] Failed { get; private set; }

        /// <summary>
        /// The number of fragments the message is divided into.
        /// </summary>
        [JsonProperty("fragments_count")]
        public long FragmentsCount { get; private set; }

    }
}
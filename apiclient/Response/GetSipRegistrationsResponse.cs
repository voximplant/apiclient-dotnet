using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetSipRegistrationsResponse : BaseResponse
    {
        /// <summary>
        /// Active SIP registrations
        /// </summary>
        [JsonProperty("result")]
        public SIPRegistrationType[] Result { get; private set; }

        /// <summary>
        /// Count rows
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
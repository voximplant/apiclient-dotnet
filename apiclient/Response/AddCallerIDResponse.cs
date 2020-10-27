using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddCallerIDResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The id of the callerID object.
        /// </summary>
        [JsonProperty("callerid_id")]
        public long CalleridId { get; private set; }

    }
}
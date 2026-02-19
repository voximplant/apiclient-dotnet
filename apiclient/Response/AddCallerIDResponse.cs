using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddCallerIDResponse : BaseResponse
    {
        /// <summary>
        /// Returns 1 if the request has been completed successfully
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// ID of the callerID object
        /// </summary>
        [JsonProperty("callerid_id")]
        public long CalleridId { get; private set; }

    }
}
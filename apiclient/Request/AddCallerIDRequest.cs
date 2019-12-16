using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddCallerIDRequest : BaseRequest
    {
        /// <summary>
        /// The callerID number in E.164 format.
        /// </summary>
        [JsonProperty("callerid_number")]
        public string CalleridNumber { get; set; }

    }
}
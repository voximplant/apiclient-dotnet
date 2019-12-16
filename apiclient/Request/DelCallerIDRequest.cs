using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelCallerIDRequest : BaseRequest
    {
        /// <summary>
        /// The id of the callerID object.
        /// </summary>
        [JsonProperty("callerid_id")]
        public long? CalleridId { get; set; }

        /// <summary>
        /// The callerID number that can be used instead of <b>callerid_id</b>.
        /// </summary>
        [JsonProperty("callerid_number")]
        public string CalleridNumber { get; set; }

    }
}
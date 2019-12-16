using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddPstnBlackListItemRequest : BaseRequest
    {
        /// <summary>
        /// The phone number in format e164 or regex pattern
        /// </summary>
        [JsonProperty("pstn_blacklist_phone")]
        public string PstnBlacklistPhone { get; set; }

    }
}
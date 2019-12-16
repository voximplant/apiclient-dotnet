using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetPstnBlackListItemRequest : BaseRequest
    {
        /// <summary>
        /// The PSTN black list item ID.
        /// </summary>
        [JsonProperty("pstn_blacklist_id")]
        public long? PstnBlacklistId { get; set; }

        /// <summary>
        /// The new phone number in format e164.
        /// </summary>
        [JsonProperty("pstn_blacklist_phone")]
        public string PstnBlacklistPhone { get; set; }

    }
}
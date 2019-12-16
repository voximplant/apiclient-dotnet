using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelPstnBlackListItemRequest : BaseRequest
    {
        /// <summary>
        /// The PSTN black list item ID.
        /// </summary>
        [JsonProperty("pstn_blacklist_id")]
        public long? PstnBlacklistId { get; set; }

    }
}
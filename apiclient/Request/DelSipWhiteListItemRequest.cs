using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelSipWhiteListItemRequest : BaseRequest
    {
        /// <summary>
        /// The SIP white list item ID to delete.
        /// </summary>
        [JsonProperty("sip_whitelist_id")]
        public long? SipWhitelistId { get; set; }

    }
}
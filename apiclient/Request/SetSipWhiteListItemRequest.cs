using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetSipWhiteListItemRequest : BaseRequest
    {
        /// <summary>
        /// The SIP white list item ID
        /// </summary>
        [JsonProperty("sip_whitelist_id")]
        public long? SipWhitelistId { get; set; }

        /// <summary>
        /// The new network address in format A.B.C.D/L or A.B.C.D/a.b.c.d
        /// (example 192.168.1.5/16)
        /// </summary>
        [JsonProperty("sip_whitelist_network")]
        public string SipWhitelistNetwork { get; set; }

    }
}
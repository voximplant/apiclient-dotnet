using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetSipWhiteList] function result item.
    /// </summary>
    public class SipWhiteListInfoType
    {
        /// <summary>
        /// The SIP white list item ID
        /// </summary>
        [JsonProperty("sip_whitelist_id")]
        public long SipWhitelistId { get; private set; }

        /// <summary>
        /// The network address in format A.B.C.D/L
        /// </summary>
        [JsonProperty("sip_whitelist_network")]
        public string SipWhitelistNetwork { get; private set; }

        /// <summary>
        /// The network address description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

    }
}
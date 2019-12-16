using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetSipWhiteListRequest : BaseRequest
    {
        /// <summary>
        /// The SIP white list item ID to filter
        /// </summary>
        [JsonProperty("sip_whitelist_id")]
        public long? SipWhitelistId { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

    }
}
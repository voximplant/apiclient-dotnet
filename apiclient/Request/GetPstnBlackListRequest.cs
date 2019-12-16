using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetPstnBlackListRequest : BaseRequest
    {
        /// <summary>
        /// The PSTN black list item ID for filter.
        /// </summary>
        [JsonProperty("pstn_blacklist_id")]
        public long? PstnBlacklistId { get; set; }

        /// <summary>
        /// The phone number in format e164 for filter.
        /// </summary>
        [JsonProperty("pstn_blacklist_phone")]
        public string PstnBlacklistPhone { get; set; }

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
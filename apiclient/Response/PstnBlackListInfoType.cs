using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The PSTN black list item info.
    /// </summary>
    public class PstnBlackListInfoType
    {
        /// <summary>
        /// The black list item ID.
        /// </summary>
        [JsonProperty("pstn_blacklist_id")]
        public long? PstnBlacklistId { get; private set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty("pstn_blacklist_phone ")]
        public string PstnBlacklistPhone  { get; private set; }

    }
}
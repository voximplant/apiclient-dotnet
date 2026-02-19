using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddSipWhiteListItemResponse : BaseResponse
    {
        /// <summary>
        /// Returns 1 if the request has been completed successfully
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The SIP white list item ID
        /// </summary>
        [JsonProperty("sip_whitelist_id")]
        public long SipWhitelistId { get; private set; }

    }
}
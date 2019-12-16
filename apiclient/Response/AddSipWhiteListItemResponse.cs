using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddSipWhiteListItemResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long? Result { get; private set; }

        /// <summary>
        /// The SIP white list item ID.
        /// </summary>
        [JsonProperty("sip_whitelist_id")]
        public long? SipWhitelistId { get; private set; }

    }
}
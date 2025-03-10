using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddPstnBlackListItemResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The PSTN black list item ID
        /// </summary>
        [JsonProperty("pstn_blacklist_id")]
        public long PstnBlacklistId { get; private set; }

    }
}
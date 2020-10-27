using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class CreateManualCallListResponse : BaseResponse
    {
        /// <summary>
        /// true
        /// </summary>
        [JsonProperty("result")]
        public bool Result { get; private set; }

        /// <summary>
        /// The number of stored records.
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

        /// <summary>
        /// The list ID.
        /// </summary>
        [JsonProperty("list_id")]
        public long ListId { get; private set; }

    }
}
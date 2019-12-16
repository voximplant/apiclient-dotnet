using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class RecoverCallListRequest : BaseRequest
    {
        /// <summary>
        /// The list Id.
        /// </summary>
        [JsonProperty("list_id")]
        public long? ListId { get; set; }

    }
}
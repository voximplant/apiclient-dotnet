using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class UpdateKeyRequest : BaseRequest
    {
        /// <summary>
        /// The key's ID
        /// </summary>
        [JsonProperty("key_id")]
        public string KeyId { get; set; }

        /// <summary>
        /// The key's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

    }
}
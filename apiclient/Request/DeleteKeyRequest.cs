using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DeleteKeyRequest : BaseRequest
    {
        /// <summary>
        /// The key's ID.
        /// </summary>
        [JsonProperty("key_id")]
        public string KeyId { get; set; }

    }
}
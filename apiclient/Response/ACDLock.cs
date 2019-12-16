using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [ACD](https://voximplant.com/docs/references/voxengine/acd) lock
    /// type.
    /// </summary>
    public class ACDLock
    {
        /// <summary>
        /// The ACD lock ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The UTC lock created time in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("created")]
        public DateTime? Created { get; private set; }

    }
}
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The API error.
    /// </summary>
    public class API_Error
    {
        /// <summary>
        /// The error code
        /// </summary>
        [JsonProperty("code")]
        public long Code { get; private set; }

        /// <summary>
        /// The error description
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; private set; }

    }
}
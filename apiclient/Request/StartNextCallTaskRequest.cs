using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class StartNextCallTaskRequest : BaseRequest
    {
        /// <summary>
        /// The list Id. Can use a set of identifiers with the separator ";"
        /// </summary>
        [JsonProperty("list_id")]
        public long? ListId { get; set; }

        /// <summary>
        /// The custom param. Use to transfer the call initiator parameters to
        /// the scenario.
        /// </summary>
        [JsonProperty("custom_params")]
        public string CustomParams { get; set; }

    }
}
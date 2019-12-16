using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetCallListDetailsRequest : BaseRequest
    {
        /// <summary>
        /// The list ID.
        /// </summary>
        [JsonProperty("list_id")]
        public long? ListId { get; set; }

        /// <summary>
        /// Maximum number of entries in the result
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// Output format (CSV/JSON/XLS). Default CSV
        /// </summary>
        [JsonProperty("output")]
        public string Output { get; set; }

        /// <summary>
        /// Encoding of the output file. Default UTF-8
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// Separator values. The default is ';'
        /// </summary>
        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }

    }
}
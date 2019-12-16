using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AppendToCallListRequest : BaseRequest
    {
        /// <summary>
        /// The call list ID
        /// </summary>
        [JsonProperty("list_id")]
        public long? ListId { get; set; }

        /// <summary>
        /// Can be used instead of <b>list_id</b>. The unique name call list
        /// </summary>
        [JsonProperty("list_name")]
        public string ListName { get; set; }

        /// <summary>
        /// Send as Body Request or multiform.
        /// </summary>
        [JsonProperty("file_content")]
        public string FileContent { get; set; }

        /// <summary>
        /// Encoding file. The default is UTF-8.
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// Escape character. Used for parsing csv
        /// </summary>
        [JsonProperty("escape")]
        public string Escape { get; set; }

        /// <summary>
        /// Separator values. The default is ';'
        /// </summary>
        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }

    }
}
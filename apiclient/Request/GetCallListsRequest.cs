using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetCallListsRequest : BaseRequest
    {
        /// <summary>
        /// The list ID to filter. Can be a list separated by the ';' symbol or
        /// the 'all' value.
        /// </summary>
        [JsonProperty("list_id")]
        public Argument<long> ListId { get; set; }

        /// <summary>
        /// Find call lists by name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Find only active call lists
        /// </summary>
        [JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// The UTC 'from' date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("from_date")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// The UTC 'to' date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("to_date")]
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// The type of call list. Available values: AUTOMATIC and MANUAL
        /// </summary>
        [JsonProperty("type_list")]
        public string TypeList { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// The application ID to filter. Can be a list separated by the ';'
        /// symbol or the 'all' value.
        /// </summary>
        [JsonProperty("application_id")]
        public Argument<long> ApplicationId { get; set; }

    }
}
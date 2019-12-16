using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DeleteRecordRequest : BaseRequest
    {
        /// <summary>
        /// Url to remove.
        /// </summary>
        [JsonProperty("record_url")]
        public string RecordUrl { get; set; }

        /// <summary>
        /// The record id for remove.
        /// </summary>
        [JsonProperty("record_id")]
        public long? RecordId { get; set; }

    }
}
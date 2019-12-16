using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetRecordStoragesRequest : BaseRequest
    {
        /// <summary>
        /// The record storage ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("record_storage_id")]
        public Argument<long> RecordStorageId { get; set; }

        /// <summary>
        /// The record storage name list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("record_storage_name")]
        public Argument<string> RecordStorageName { get; set; }

        /// <summary>
        /// Set true to get the private record storages. If set to true, there is
        /// the __is_public : bool__ parameter in a response.
        /// </summary>
        [JsonProperty("with_private")]
        public bool? WithPrivate { get; set; }

    }
}
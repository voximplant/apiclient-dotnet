using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetRecordStorages] function result.
    /// </summary>
    public class RecordStorageInfoType
    {
        /// <summary>
        /// The record storage ID
        /// </summary>
        [JsonProperty("record_storage_id")]
        public long? RecordStorageId { get; private set; }

        /// <summary>
        /// The record storage name
        /// </summary>
        [JsonProperty("record_storage_name")]
        public string RecordStorageName { get; private set; }

    }
}
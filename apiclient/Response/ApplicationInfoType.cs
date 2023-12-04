using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetApplications] function result.
    /// </summary>
    public class ApplicationInfoType
    {
        /// <summary>
        /// The application ID
        /// </summary>
        [JsonProperty("application_id")]
        public long ApplicationId { get; private set; }

        /// <summary>
        /// The full application name
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; private set; }

        /// <summary>
        /// The application editing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("modified")]
        public DateTime Modified { get; private set; }

        /// <summary>
        /// This flag indicates whether a secure storage for logs and records is enabled or not
        /// </summary>
        [JsonProperty("secure_record_storage")]
        public bool SecureRecordStorage { get; private set; }

    }
}
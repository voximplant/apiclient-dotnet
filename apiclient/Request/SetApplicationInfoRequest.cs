using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetApplicationInfoRequest : BaseRequest
    {
        /// <summary>
        /// The application ID.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// Can be used instead of <b>application_id</b>.
        /// </summary>
        [JsonProperty("required_application_name")]
        public string RequiredApplicationName { get; set; }

        /// <summary>
        /// The new short application name in format [a-z][a-z0-9-]{1,79}
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Enable secure storage for all logs and records of the application
        /// </summary>
        [JsonProperty("secure_record_storage")]
        public bool? SecureRecordStorage { get; set; }

    }
}
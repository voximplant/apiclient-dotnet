using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddApplicationRequest : BaseRequest
    {
        /// <summary>
        /// The short application name in format \[a-z\]\[a-z0-9-\]{1,64}
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
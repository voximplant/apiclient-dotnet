using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class SetApplicationInfoResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long? Result { get; private set; }

        /// <summary>
        /// The new full application name
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; private set; }

        /// <summary>
        /// This flag indicates whether a secure storage for logs and records is
        /// enabled or not.
        /// </summary>
        [JsonProperty("secure_record_storage")]
        public bool? SecureRecordStorage { get; private set; }

    }
}
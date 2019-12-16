using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelUserRequest : BaseRequest
    {
        /// <summary>
        /// The user ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("user_id")]
        public Argument<long> UserId { get; set; }

        /// <summary>
        /// The user name list separated by the ';' symbol that can be used
        /// instead of <b>user_id</b>.
        /// </summary>
        [JsonProperty("user_name")]
        public Argument<string> UserName { get; set; }

        /// <summary>
        /// Delete the specified users bound to the application ID. It is
        /// required if the <b>user_name</b> is specified.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// Delete the specified users bound to the application name. Could be
        /// used instead of the <b>application_id</b> parameter.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

    }
}
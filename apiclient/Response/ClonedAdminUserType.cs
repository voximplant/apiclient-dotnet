using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The cloned admin user info.
    /// </summary>
    public class ClonedAdminUserType
    {
        /// <summary>
        /// The admin user ID
        /// </summary>
        [JsonProperty("admin_user_id")]
        public long AdminUserId { get; private set; }

        /// <summary>
        /// The admin user name
        /// </summary>
        [JsonProperty("admin_user_name")]
        public string AdminUserName { get; private set; }

        /// <summary>
        /// The API key of the admin user
        /// </summary>
        [JsonProperty("admin_user_api_key")]
        public string AdminUserApiKey { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The cloned admin role info.
    /// </summary>
    public class ClonedAdminRoleType
    {
        /// <summary>
        /// The admin role ID
        /// </summary>
        [JsonProperty("admin_role_id")]
        public long AdminRoleId { get; private set; }

        /// <summary>
        /// The admin role name
        /// </summary>
        [JsonProperty("admin_role_name")]
        public string AdminRoleName { get; private set; }

    }
}
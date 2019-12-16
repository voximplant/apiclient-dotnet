using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetAdminUsers] function result.
    /// </summary>
    public class AdminUserType
    {
        /// <summary>
        /// The admin user ID.
        /// </summary>
        [JsonProperty("admin_user_id")]
        public long? AdminUserId { get; private set; }

        /// <summary>
        /// The admin user name.
        /// </summary>
        [JsonProperty("admin_user_name")]
        public string AdminUserName { get; private set; }

        /// <summary>
        /// The admin user display name.
        /// </summary>
        [JsonProperty("admin_user_display_name")]
        public string AdminUserDisplayName { get; private set; }

        /// <summary>
        /// Is allowed to logon?
        /// </summary>
        [JsonProperty("admin_user_active")]
        public bool? AdminUserActive { get; private set; }

        /// <summary>
        /// The admin user editing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("modified")]
        public DateTime? Modified { get; private set; }

        /// <summary>
        /// The allowed access entries (the API function names).
        /// </summary>
        [JsonProperty("access_entries")]
        public string[] AccessEntries { get; private set; }

        /// <summary>
        /// The attached admin roles.
        /// </summary>
        [JsonProperty("admin_roles")]
        public IReadOnlyList<AdminRoleType> AdminRoles { get; private set; }

    }
}
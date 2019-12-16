using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetAdminRoles] function result.
    /// </summary>
    public class AdminRoleType
    {
        /// <summary>
        /// The admin role ID.
        /// </summary>
        [JsonProperty("admin_role_id")]
        public long? AdminRoleId { get; private set; }

        /// <summary>
        /// The admin role name.
        /// </summary>
        [JsonProperty("admin_role_name")]
        public string AdminRoleName { get; private set; }

        /// <summary>
        /// If false the allowed and denied entries have no affect.
        /// </summary>
        [JsonProperty("admin_role_active")]
        public bool? AdminRoleActive { get; private set; }

        /// <summary>
        /// Is a system role?
        /// </summary>
        [JsonProperty("system_role")]
        public bool? SystemRole { get; private set; }

        /// <summary>
        /// The admin role editing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("modified")]
        public DateTime? Modified { get; private set; }

        /// <summary>
        /// The allowed access entries (the API function names).
        /// </summary>
        [JsonProperty("allowed_entries")]
        public string[] AllowedEntries { get; private set; }

        /// <summary>
        /// The denied access entries (the API function names).
        /// </summary>
        [JsonProperty("denied_entries")]
        public string[] DeniedEntries { get; private set; }

    }
}
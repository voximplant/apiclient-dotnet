using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetAdminRolesRequest : BaseRequest
    {
        /// <summary>
        /// The admin role ID to filter.
        /// </summary>
        [JsonProperty("admin_role_id")]
        public long? AdminRoleId { get; set; }

        /// <summary>
        /// The admin role name part to filter.
        /// </summary>
        [JsonProperty("admin_role_name")]
        public string AdminRoleName { get; set; }

        /// <summary>
        /// The admin role active flag to filter.
        /// </summary>
        [JsonProperty("admin_role_active")]
        public bool? AdminRoleActive { get; set; }

        /// <summary>
        /// Set true to get the permissions.
        /// </summary>
        [JsonProperty("with_entries")]
        public bool? WithEntries { get; set; }

        /// <summary>
        /// Set false to omit the account roles.
        /// </summary>
        [JsonProperty("with_account_roles")]
        public bool? WithAccountRoles { get; set; }

        /// <summary>
        /// Set false to omit the parent roles.
        /// </summary>
        [JsonProperty("with_parent_roles")]
        public bool? WithParentRoles { get; set; }

        /// <summary>
        /// Set false to omit the system roles.
        /// </summary>
        [JsonProperty("with_system_roles")]
        public bool? WithSystemRoles { get; set; }

        /// <summary>
        /// The attached admin user ID list separated by the ';' symbol or the
        /// 'all' value.
        /// </summary>
        [JsonProperty("included_admin_user_id")]
        public Argument<long> IncludedAdminUserId { get; set; }

        /// <summary>
        /// The not attached admin user ID list separated by the ';' symbol or
        /// the 'all' value.
        /// </summary>
        [JsonProperty("excluded_admin_user_id")]
        public Argument<long> ExcludedAdminUserId { get; set; }

        /// <summary>
        /// Set false to get roles with partial admin user list matching.
        /// </summary>
        [JsonProperty("full_admin_users_matching")]
        public string FullAdminUsersMatching { get; set; }

        /// <summary>
        /// The admin user to show in the 'admin_users' field output.
        /// </summary>
        [JsonProperty("showing_admin_user_id")]
        public long? ShowingAdminUserId { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

    }
}
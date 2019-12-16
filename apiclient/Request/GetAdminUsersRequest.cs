using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetAdminUsersRequest : BaseRequest
    {
        /// <summary>
        /// The admin user ID to filter.
        /// </summary>
        [JsonProperty("required_admin_user_id")]
        public long? RequiredAdminUserId { get; set; }

        /// <summary>
        /// The admin user name part to filter.
        /// </summary>
        [JsonProperty("required_admin_user_name")]
        public string RequiredAdminUserName { get; set; }

        /// <summary>
        /// The admin user display name part to filter.
        /// </summary>
        [JsonProperty("admin_user_display_name")]
        public string AdminUserDisplayName { get; set; }

        /// <summary>
        /// The admin user active flag to filter.
        /// </summary>
        [JsonProperty("admin_user_active")]
        public bool? AdminUserActive { get; set; }

        /// <summary>
        /// Set true to get the attached admin roles.
        /// </summary>
        [JsonProperty("with_roles")]
        public bool? WithRoles { get; set; }

        /// <summary>
        /// Set true to get the admin user permissions.
        /// </summary>
        [JsonProperty("with_access_entries")]
        public bool? WithAccessEntries { get; set; }

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
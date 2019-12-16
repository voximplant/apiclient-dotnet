using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddAdminUserRequest : BaseRequest
    {
        /// <summary>
        /// The admin user name. The length must be less than 50.
        /// </summary>
        [JsonProperty("new_admin_user_name")]
        public string NewAdminUserName { get; set; }

        /// <summary>
        /// The admin user display name. The length must be less than 256.
        /// </summary>
        [JsonProperty("admin_user_display_name")]
        public string AdminUserDisplayName { get; set; }

        /// <summary>
        /// The admin user password. The length must be at least 6 symbols.
        /// </summary>
        [JsonProperty("new_admin_user_password")]
        public string NewAdminUserPassword { get; set; }

        /// <summary>
        /// The admin user enable flag.
        /// </summary>
        [JsonProperty("admin_user_active")]
        public bool? AdminUserActive { get; set; }

        /// <summary>
        /// The role(s) ID created via <a
        /// href='//voximplant.com/docs/references/httpapi/managing_admin_roles'>Managing
        /// Admin Roles</a> methods. The attaching admin role ID list separated
        /// by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("admin_role_id")]
        public string AdminRoleId { get; set; }

        /// <summary>
        /// The role(s) name(s) created via <a
        /// href='//voximplant.com/docs/references/httpapi/managing_admin_roles'>Managing
        /// Admin Roles</a> methods. The attaching admin role name that can be
        /// used instead of <b>admin_role_id</b>.
        /// </summary>
        [JsonProperty("admin_role_name")]
        public Argument<string> AdminRoleName { get; set; }

    }
}
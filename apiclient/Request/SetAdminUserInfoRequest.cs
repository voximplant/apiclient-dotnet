using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetAdminUserInfoRequest : BaseRequest
    {
        /// <summary>
        /// The admin user to edit.
        /// </summary>
        [JsonProperty("required_admin_user_id")]
        public long? RequiredAdminUserId { get; set; }

        /// <summary>
        /// The admin user to edit, can be used instead of
        /// <b>required_admin_user_id</b>.
        /// </summary>
        [JsonProperty("required_admin_user_name")]
        public string RequiredAdminUserName { get; set; }

        /// <summary>
        /// The new admin user name. The length must be less than 50.
        /// </summary>
        [JsonProperty("new_admin_user_name")]
        public string NewAdminUserName { get; set; }

        /// <summary>
        /// The new admin user display name. The length must be less than 256.
        /// </summary>
        [JsonProperty("admin_user_display_name")]
        public string AdminUserDisplayName { get; set; }

        /// <summary>
        /// The new admin user password. The length must be at least 6 symbols.
        /// </summary>
        [JsonProperty("new_admin_user_password")]
        public string NewAdminUserPassword { get; set; }

        /// <summary>
        /// The admin user enable flag.
        /// </summary>
        [JsonProperty("admin_user_active")]
        public bool? AdminUserActive { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AttachAdminRoleRequest : BaseRequest
    {
        /// <summary>
        /// The admin user ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("required_admin_user_id")]
        public Argument<long> RequiredAdminUserId { get; set; }

        /// <summary>
        /// The admin user name to bind, can be used instead of
        /// <b>required_admin_user_id</b>.
        /// </summary>
        [JsonProperty("required_admin_user_name")]
        public Argument<string> RequiredAdminUserName { get; set; }

        /// <summary>
        /// The role(s) ID created via <a
        /// href='//voximplant.com/docs/references/httpapi/adminroles'>Managing
        /// Admin Roles</a> methods. The attached admin role ID list separated by
        /// the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("admin_role_id")]
        public Argument<long> AdminRoleId { get; set; }

        /// <summary>
        /// The role(s) name(s) created via <a
        /// href='//voximplant.com/docs/references/httpapi/adminroles'>Managing
        /// Admin Roles</a> methods. The admin role name to attach, can be used
        /// instead of <b>admin_role_id</b>.
        /// </summary>
        [JsonProperty("admin_role_name")]
        public Argument<string> AdminRoleName { get; set; }

        /// <summary>
        /// The merge mode. The following values are possible: add, del, set.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

    }
}
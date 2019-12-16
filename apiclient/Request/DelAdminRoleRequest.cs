using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelAdminRoleRequest : BaseRequest
    {
        /// <summary>
        /// The admin role ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("admin_role_id")]
        public Argument<long> AdminRoleId { get; set; }

        /// <summary>
        /// The admin role name to delete, can be used instead of
        /// <b>admin_role_id</b>.
        /// </summary>
        [JsonProperty("admin_role_name")]
        public Argument<string> AdminRoleName { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelAdminUserRequest : BaseRequest
    {
        /// <summary>
        /// The admin user ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("required_admin_user_id")]
        public Argument<long> RequiredAdminUserId { get; set; }

        /// <summary>
        /// The admin user name to delete, can be used instead of
        /// <b>required_admin_user_id</b>.
        /// </summary>
        [JsonProperty("required_admin_user_name")]
        public Argument<string> RequiredAdminUserName { get; set; }

    }
}
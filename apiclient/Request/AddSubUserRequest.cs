using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddSubUserRequest : BaseRequest
    {
        /// <summary>
        /// Login of a new subuser for <a
        /// href='/docs/howtos/integration/httpapi/auth'>authentication</a>,
        /// should be unique within the Voximplant account. The login specified
        /// is always converted to lowercase.
        /// </summary>
        [JsonProperty("new_subuser_name")]
        public string NewSubuserName { get; set; }

        /// <summary>
        /// Password of a new subuser, plain text.
        /// </summary>
        [JsonProperty("new_subuser_password")]
        public string NewSubuserPassword { get; set; }

        /// <summary>
        /// The role id list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("role_id")]
        public Argument<long> RoleId { get; set; }

        /// <summary>
        /// The role name list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("role_name")]
        public Argument<string> RoleName { get; set; }

        /// <summary>
        /// Description of a new subuser.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

    }
}
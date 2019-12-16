using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class RemoveSubUserRolesRequest : BaseRequest
    {
        /// <summary>
        /// The subuser's ID.
        /// </summary>
        [JsonProperty("subuser_id")]
        public long? SubuserId { get; set; }

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
        /// Remove roles from all subuser keys.
        /// </summary>
        [JsonProperty("force")]
        public bool? Force { get; set; }

    }
}
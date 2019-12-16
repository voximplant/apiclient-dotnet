using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class RemoveKeyRolesRequest : BaseRequest
    {
        /// <summary>
        /// The key's ID.
        /// </summary>
        [JsonProperty("key_id")]
        public string KeyId { get; set; }

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

    }
}
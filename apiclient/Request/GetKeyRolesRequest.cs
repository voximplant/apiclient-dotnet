using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetKeyRolesRequest : BaseRequest
    {
        /// <summary>
        /// The key's ID.
        /// </summary>
        [JsonProperty("key_id")]
        public string KeyId { get; set; }

        /// <summary>
        /// Show the roles' additional properties.
        /// </summary>
        [JsonProperty("with_expanded_roles")]
        public bool? WithExpandedRoles { get; set; }

    }
}
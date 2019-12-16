using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetSubUserRolesRequest : BaseRequest
    {
        /// <summary>
        /// The subuser's ID.
        /// </summary>
        [JsonProperty("subuser_id")]
        public long? SubuserId { get; set; }

        /// <summary>
        /// Show the roles' additional properties.
        /// </summary>
        [JsonProperty("with_expanded_roles")]
        public bool? WithExpandedRoles { get; set; }

    }
}
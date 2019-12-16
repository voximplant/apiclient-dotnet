using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetSubUsers] function result.
    /// </summary>
    public class SubUserView
    {
        /// <summary>
        /// The subuser ID.
        /// </summary>
        [JsonProperty("subuser_id")]
        public long? SubuserId { get; private set; }

        /// <summary>
        /// The subuser name, can be used as __subuser_login__ to <a
        /// href="#how-auth-works">authenticate</a>.
        /// </summary>
        [JsonProperty("subuser_name")]
        public string SubuserName { get; private set; }

        /// <summary>
        /// The subuser description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The subuser roles.
        /// </summary>
        [JsonProperty("roles")]
        public IReadOnlyList<RoleView> Roles { get; private set; }

    }
}
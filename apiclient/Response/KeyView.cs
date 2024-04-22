using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetKeys] function result.
    /// </summary>
    public class KeyView
    {
        /// <summary>
        /// The key ID
        /// </summary>
        [JsonProperty("key_id")]
        public string KeyId { get; private set; }

        /// <summary>
        /// The key roles
        /// </summary>
        [JsonProperty("roles")]
        public RoleView[] Roles { get; private set; }

        /// <summary>
        /// The key description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The key subuser
        /// </summary>
        [JsonProperty("subuser")]
        public SubUserView[] Subuser { get; private set; }

        /// <summary>
        /// The key's name
        /// </summary>
        [JsonProperty("key_name")]
        public string KeyName { get; private set; }

    }
}
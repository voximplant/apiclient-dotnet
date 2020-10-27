using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetRoleGroups] function result.
    /// </summary>
    public class RoleGroupView
    {
        /// <summary>
        /// The role group ID.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; private set; }

        /// <summary>
        /// The role group name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

    }
}
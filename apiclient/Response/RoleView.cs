using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The role view.
    /// </summary>
    public class RoleView
    {
        /// <summary>
        /// The role name
        /// </summary>
        [JsonProperty("role_name")]
        public string RoleName { get; private set; }

        /// <summary>
        /// The role ID
        /// </summary>
        [JsonProperty("role_id")]
        public long RoleId { get; private set; }

        /// <summary>
        /// Whether the role is inherited
        /// </summary>
        [JsonProperty("inherited")]
        public bool? Inherited { get; private set; }

        /// <summary>
        /// Child roles IDs array
        /// </summary>
        [JsonProperty("child_ids")]
        public long[] ChildIds { get; private set; }

        /// <summary>
        /// Parent roles IDs array
        /// </summary>
        [JsonProperty("parent_role_id")]
        public long[] ParentRoleId { get; private set; }

        /// <summary>
        /// Whether the role is gui only
        /// </summary>
        [JsonProperty("gui_only")]
        public bool GuiOnly { get; private set; }

    }
}
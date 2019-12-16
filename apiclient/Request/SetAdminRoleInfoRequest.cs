using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetAdminRoleInfoRequest : BaseRequest
    {
        /// <summary>
        /// The admin role to edit.
        /// </summary>
        [JsonProperty("admin_role_id")]
        public long? AdminRoleId { get; set; }

        /// <summary>
        /// The admin role to edit, can be used instead of <b>admin_role_id</b>.
        /// </summary>
        [JsonProperty("admin_role_name")]
        public string AdminRoleName { get; set; }

        /// <summary>
        /// The new admin role name. The length must be less than 50.
        /// </summary>
        [JsonProperty("new_admin_role_name")]
        public string NewAdminRoleName { get; set; }

        /// <summary>
        /// The admin role enable flag. If false the allowed and denied entries
        /// have no affect.
        /// </summary>
        [JsonProperty("admin_role_active")]
        public bool? AdminRoleActive { get; set; }

        /// <summary>
        /// The modification mode of the permission lists (allowed_entries and
        /// denied_entries). The following values are possible: add, del, set.
        /// </summary>
        [JsonProperty("entry_modification_mode")]
        public string EntryModificationMode { get; set; }

        /// <summary>
        /// The list of allowed access entry changes separated by the ';' symbol
        /// (the API function names).
        /// </summary>
        [JsonProperty("allowed_entries")]
        public Argument<string> AllowedEntries { get; set; }

        /// <summary>
        /// The list of denied access entry changes separated by the ';' symbol
        /// (the API function names).
        /// </summary>
        [JsonProperty("denied_entries")]
        public Argument<string> DeniedEntries { get; set; }

        /// <summary>
        /// The admin role ID list separated by the ';' symbol or the 'all'
        /// value. The list specifies the roles from which the allowed_entries
        /// and denied_entries will be merged.
        /// </summary>
        [JsonProperty("like_admin_role_id")]
        public Argument<long> LikeAdminRoleId { get; set; }

        /// <summary>
        /// The admin role name, can be used instead of
        /// <b>like_admin_role_id</b>. The name specifies a role from which the
        /// allowed_entries and denied_entries will be merged.
        /// </summary>
        [JsonProperty("like_admin_role_name")]
        public Argument<string> LikeAdminRoleName { get; set; }

    }
}
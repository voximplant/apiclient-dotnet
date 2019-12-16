using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class CreateKeyRequest : BaseRequest
    {
        /// <summary>
        /// The key's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The role ID list separated by the ';' symbol. Use it instead of
        /// **role_name**, but not combine with.
        /// </summary>
        [JsonProperty("role_id")]
        public Argument<long> RoleId { get; set; }

        /// <summary>
        /// The role name list separated by the ';' symbol. Use it instead of
        /// **role_id**, but not combine with.
        /// </summary>
        [JsonProperty("role_name")]
        public Argument<string> RoleName { get; set; }

    }
}
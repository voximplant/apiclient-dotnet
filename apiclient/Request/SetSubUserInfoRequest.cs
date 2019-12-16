using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetSubUserInfoRequest : BaseRequest
    {
        /// <summary>
        /// The subuser's ID.
        /// </summary>
        [JsonProperty("subuser_id")]
        public long? SubuserId { get; set; }

        /// <summary>
        /// The subuser old password. It is required if __new_subuser_password__
        /// is specified.
        /// </summary>
        [JsonProperty("old_subuser_password")]
        public string OldSubuserPassword { get; set; }

        /// <summary>
        /// The new user password. The length must be at least 6 symbols.
        /// </summary>
        [JsonProperty("new_subuser_password")]
        public string NewSubuserPassword { get; set; }

        /// <summary>
        /// The new subuser description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

    }
}
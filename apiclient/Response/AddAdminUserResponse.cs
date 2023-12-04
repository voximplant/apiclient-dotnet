using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddAdminUserResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The new admin user ID
        /// </summary>
        [JsonProperty("admin_user_id")]
        public long AdminUserId { get; private set; }

        /// <summary>
        /// The admin user API key
        /// </summary>
        [JsonProperty("admin_user_api_key")]
        public string AdminUserApiKey { get; private set; }

    }
}
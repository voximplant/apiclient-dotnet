using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddAdminRoleResponse : BaseResponse
    {
        /// <summary>
        /// Returns 1 if the request has been completed successfully
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The new admin role ID
        /// </summary>
        [JsonProperty("admin_role_id")]
        public long AdminRoleId { get; private set; }

    }
}
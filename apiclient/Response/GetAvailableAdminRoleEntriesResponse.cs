using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetAvailableAdminRoleEntriesResponse : BaseResponse
    {
        /// <summary>
        /// Array of the admin role entries.
        /// </summary>
        [JsonProperty("result")]
        public string[] Result { get; private set; }

    }
}
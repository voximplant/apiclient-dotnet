using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetRolesRequest : BaseRequest
    {
        /// <summary>
        /// The role group.
        /// </summary>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }

    }
}
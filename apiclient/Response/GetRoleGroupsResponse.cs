using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetRoleGroupsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public RoleGroupView[] Result { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetSubUserRolesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public RoleView[] Result { get; private set; }

    }
}
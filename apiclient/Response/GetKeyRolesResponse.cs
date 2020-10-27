using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetKeyRolesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public RoleView[] Result { get; private set; }

    }
}
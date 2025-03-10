using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetRolesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public RoleView[] Result { get; private set; }

    }
}
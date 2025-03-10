using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetSubUsersResponse : BaseResponse
    {

        [JsonProperty("result")]
        public SubUserView[] Result { get; private set; }

    }
}
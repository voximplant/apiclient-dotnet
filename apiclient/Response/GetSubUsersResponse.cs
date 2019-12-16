using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetSubUsersResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<SubUserView> Result { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetPushCredentialResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<PushCredentialInfo> Result { get; private set; }

    }
}
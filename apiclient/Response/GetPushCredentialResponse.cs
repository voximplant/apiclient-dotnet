using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetPushCredentialResponse : BaseResponse
    {

        [JsonProperty("result")]
        public PushCredentialInfo[] Result { get; private set; }

    }
}
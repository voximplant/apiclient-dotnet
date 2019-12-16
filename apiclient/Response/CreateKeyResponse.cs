using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class CreateKeyResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<KeyInfo> Result { get; private set; }

    }
}
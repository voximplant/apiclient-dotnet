using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class CreateKeyResponse : BaseResponse
    {

        [JsonProperty("result")]
        public KeyInfo[] Result { get; private set; }

    }
}
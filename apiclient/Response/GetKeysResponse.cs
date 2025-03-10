using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetKeysResponse : BaseResponse
    {

        [JsonProperty("result")]
        public KeyView[] Result { get; private set; }

    }
}
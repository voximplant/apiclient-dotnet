using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class DelSubUserResponse : BaseResponse
    {

        [JsonProperty("result")]
        public long Result { get; private set; }

    }
}
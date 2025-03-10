using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddSubUserResponse : BaseResponse
    {

        [JsonProperty("result")]
        public SubUserID Result { get; private set; }

    }
}
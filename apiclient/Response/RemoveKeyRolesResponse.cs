using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class RemoveKeyRolesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public long? Result { get; private set; }

    }
}
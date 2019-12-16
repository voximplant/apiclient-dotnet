using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetKeysResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<KeyView> Result { get; private set; }

    }
}
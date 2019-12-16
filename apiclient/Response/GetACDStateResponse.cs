using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetACDStateResponse : BaseResponse
    {

        [JsonProperty("result")]
        public ACDStateType Result { get; private set; }

    }
}
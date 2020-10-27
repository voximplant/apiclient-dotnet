using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class LinkregulationAddressResponse : BaseResponse
    {

        [JsonProperty("result")]
        public bool Result { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetResourcePriceResponse : BaseResponse
    {
        /// <summary>
        /// The resource prices
        /// </summary>
        [JsonProperty("result")]
        public ResourcePrice[] Result { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetSubscriptionPriceResponse : BaseResponse
    {
        /// <summary>
        /// The subscription template prices
        /// </summary>
        [JsonProperty("result")]
        public SubscriptionTemplateType[] Result { get; private set; }

    }
}
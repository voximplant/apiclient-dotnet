using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetAccountInfoResponse : BaseResponse
    {
        /// <summary>
        /// Account's info as the [AccountInfoType] object instance.
        /// </summary>
        [JsonProperty("result")]
        public AccountInfoType Result { get; private set; }

        /// <summary>
        /// The preferred address for the http api requests.
        /// </summary>
        [JsonProperty("api_address")]
        public string ApiAddress { get; private set; }

    }
}
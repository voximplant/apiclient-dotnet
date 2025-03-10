using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetMoneyAmountToChargeResponse : BaseResponse
    {
        /// <summary>
        /// Result
        /// </summary>
        [JsonProperty("result")]
        public GetMoneyAmountToChargeResult Result { get; private set; }

    }
}
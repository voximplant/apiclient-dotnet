using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class ChargeAccountResponse : BaseResponse
    {
        /// <summary>
        /// Result
        /// </summary>
        [JsonProperty("result")]
        public ChargeAccountResult Result { get; private set; }

        /// <summary>
        /// The current account state
        /// </summary>
        [JsonProperty("account_info")]
        public ShortAccountInfoType AccountInfo { get; private set; }

    }
}
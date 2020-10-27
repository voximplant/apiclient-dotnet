using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class TransferMoneyToUserResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The new account balance.
        /// </summary>
        [JsonProperty("balance")]
        public decimal Balance { get; private set; }

    }
}
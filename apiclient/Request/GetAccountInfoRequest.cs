using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetAccountInfoRequest : BaseRequest
    {
        /// <summary>
        /// Set true to get the account's live balance.
        /// </summary>
        [JsonProperty("return_live_balance")]
        public bool? ReturnLiveBalance { get; set; }

    }
}
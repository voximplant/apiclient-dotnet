using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddUserResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The new user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; private set; }

    }
}
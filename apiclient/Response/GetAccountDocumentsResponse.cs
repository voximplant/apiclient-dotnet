using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetAccountDocumentsResponse : BaseResponse
    {
        /// <summary>
        /// The account verifications.
        /// </summary>
        [JsonProperty("result")]
        public AccountVerifications[] Result { get; private set; }

    }
}
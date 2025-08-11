using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetAccountDocumentsResponse : BaseResponse
    {
        /// <summary>
        /// The account documents with verification states
        /// </summary>
        [JsonProperty("result")]
        public AccountDocumentsType[] Result { get; private set; }

    }
}
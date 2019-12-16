using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetDialogflowKeysResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<DialogflowKeyInfo> Result { get; private set; }

    }
}
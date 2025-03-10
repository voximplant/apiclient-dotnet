using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetDialogflowKeysResponse : BaseResponse
    {

        [JsonProperty("result")]
        public DialogflowKeyInfo[] Result { get; private set; }

    }
}
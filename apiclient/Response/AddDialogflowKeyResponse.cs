using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddDialogflowKeyResponse : BaseResponse
    {

        [JsonProperty("result")]
        public long Result { get; private set; }


        [JsonProperty("dialogflow_key_id")]
        public long DialogflowKeyId { get; private set; }

    }
}
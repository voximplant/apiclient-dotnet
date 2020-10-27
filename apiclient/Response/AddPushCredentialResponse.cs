using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddPushCredentialResponse : BaseResponse
    {

        [JsonProperty("result")]
        public long Result { get; private set; }


        [JsonProperty("push_credential_id")]
        public long PushCredentialId { get; private set; }

    }
}
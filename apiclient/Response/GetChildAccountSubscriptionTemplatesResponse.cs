using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetChildAccountSubscriptionTemplatesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<ChildAccountSubscriptionTemplateType> Result { get; private set; }

    }
}
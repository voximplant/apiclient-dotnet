using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetChildAccountSubscriptionsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<ChildAccountSubscriptionType> Result { get; private set; }

    }
}
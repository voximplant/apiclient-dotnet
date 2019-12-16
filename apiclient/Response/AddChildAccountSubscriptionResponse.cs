using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddChildAccountSubscriptionResponse : BaseResponse
    {

        [JsonProperty("result")]
        public long? Result { get; private set; }


        [JsonProperty("subscriptions")]
        public IReadOnlyList<ChildAccountSubscriptionType> Subscriptions { get; private set; }

    }
}
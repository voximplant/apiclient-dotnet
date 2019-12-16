using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetActualPhoneNumberRegionResponse : BaseResponse
    {

        [JsonProperty("result")]
        public PhoneNumberCountryRegionInfoType Result { get; private set; }

    }
}
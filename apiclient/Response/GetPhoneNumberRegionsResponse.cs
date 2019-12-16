using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetPhoneNumberRegionsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<PhoneNumberCountryRegionInfoType> Result { get; private set; }

    }
}
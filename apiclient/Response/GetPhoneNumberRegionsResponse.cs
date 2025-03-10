using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetPhoneNumberRegionsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public PhoneNumberCountryRegionInfoType[] Result { get; private set; }

    }
}
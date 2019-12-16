using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetPhoneNumberCountryStatesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<PhoneNumberCountryStateInfoType> Result { get; private set; }

    }
}
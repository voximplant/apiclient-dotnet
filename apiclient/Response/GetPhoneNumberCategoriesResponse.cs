using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetPhoneNumberCategoriesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<PhoneNumberCountryInfoType> Result { get; private set; }

    }
}
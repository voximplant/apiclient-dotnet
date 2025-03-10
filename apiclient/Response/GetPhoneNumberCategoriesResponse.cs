using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetPhoneNumberCategoriesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public PhoneNumberCountryInfoType[] Result { get; private set; }

    }
}
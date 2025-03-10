using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AttachPhoneNumberResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The attached phone numbers
        /// </summary>
        [JsonProperty("phone_numbers")]
        public NewAttachedPhoneInfoType[] PhoneNumbers { get; private set; }

    }
}
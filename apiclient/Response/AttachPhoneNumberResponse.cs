using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AttachPhoneNumberResponse : BaseResponse
    {
        /// <summary>
        /// Returns 1 if the request has been completed successfully
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
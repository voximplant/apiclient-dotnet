using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class CreateSipRegistrationResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The sip registration id
        /// </summary>
        [JsonProperty("sip_registration_id")]
        public long SipRegistrationId { get; private set; }

        /// <summary>
        /// The current account state
        /// </summary>
        [JsonProperty("account_info")]
        public ShortAccountInfoType AccountInfo { get; private set; }

    }
}
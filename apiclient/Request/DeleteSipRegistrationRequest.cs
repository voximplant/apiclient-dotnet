using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DeleteSipRegistrationRequest : BaseRequest
    {
        /// <summary>
        /// The registration ID
        /// </summary>
        [JsonProperty("sip_registration_id")]
        public long? SipRegistrationId { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DeactivatePhoneNumberRequest : BaseRequest
    {
        /// <summary>
        /// The phone ID.
        /// </summary>
        [JsonProperty("phone_id")]
        public long? PhoneId { get; set; }

        /// <summary>
        /// The phone number that can be used instead of <b>phone_id</b>.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

    }
}
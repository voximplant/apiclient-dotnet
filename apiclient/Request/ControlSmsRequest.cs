using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class ControlSmsRequest : BaseRequest
    {
        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The SMS control command. The following values are possible: enable,
        /// disable.
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; set; }

    }
}
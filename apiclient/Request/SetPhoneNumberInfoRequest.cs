using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetPhoneNumberInfoRequest : BaseRequest
    {
        /// <summary>
        /// The phone ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("phone_id")]
        public Argument<long> PhoneId { get; set; }

        /// <summary>
        /// The phone number list separated by the ';' symbol that can be used
        /// instead of <b>phone_id</b>.
        /// </summary>
        [JsonProperty("phone_number")]
        public Argument<string> PhoneNumber { get; set; }

        /// <summary>
        /// Set true to enable the auto charging.
        /// </summary>
        [JsonProperty("auto_charge")]
        public bool? AutoCharge { get; set; }

    }
}
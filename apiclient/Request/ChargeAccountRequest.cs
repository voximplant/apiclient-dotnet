using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class ChargeAccountRequest : BaseRequest
    {
        /// <summary>
        /// The phone ID list separated by the ';' symbol or the 'all' value. You
        /// should specify the phones having the auto_charge=false.
        /// </summary>
        [JsonProperty("phone_id")]
        public Argument<long> PhoneId { get; set; }

        /// <summary>
        /// Can be used instead of <b>phone_id</b>. The phone number list
        /// separated by the ';' symbol or the 'all' value. You should specify
        /// the phones having the auto_charge=false.
        /// </summary>
        [JsonProperty("phone_number")]
        public Argument<string> PhoneNumber { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class ActivateCallerIDRequest : BaseRequest
    {
        /// <summary>
        /// The id of the callerID object.
        /// </summary>
        [JsonProperty("callerid_id")]
        public long? CalleridId { get; set; }

        /// <summary>
        /// The callerID number that can be used instead of <b>callerid_id</b>.
        /// </summary>
        [JsonProperty("callerid_number")]
        public string CalleridNumber { get; set; }

        /// <summary>
        /// The verification code, see the VerifyCallerID function.
        /// </summary>
        [JsonProperty("verification_code")]
        public string VerificationCode { get; set; }

    }
}
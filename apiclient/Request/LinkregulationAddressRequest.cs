using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class LinkregulationAddressRequest : BaseRequest
    {
        /// <summary>
        /// The regulation address ID
        /// </summary>
        [JsonProperty("regulation_address_id")]
        public long? RegulationAddressId { get; set; }

        /// <summary>
        /// The phone ID for link
        /// </summary>
        [JsonProperty("phone_id")]
        public long? PhoneId { get; set; }

        /// <summary>
        /// The phone number for link
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

    }
}
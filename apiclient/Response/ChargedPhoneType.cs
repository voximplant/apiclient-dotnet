using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The charged phone info.
    /// </summary>
    public class ChargedPhoneType
    {
        /// <summary>
        /// The phone ID.
        /// </summary>
        [JsonProperty("phone_id")]
        public long PhoneId { get; private set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// Subscription is frozen.
        /// </summary>
        [JsonProperty("deactivated")]
        public bool Deactivated { get; private set; }

        /// <summary>
        /// Phone number has been charged.
        /// </summary>
        [JsonProperty("is_charged")]
        public bool IsCharged { get; private set; }

    }
}
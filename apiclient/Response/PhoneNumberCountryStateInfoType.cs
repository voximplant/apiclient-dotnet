using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetPhoneNumberCountryStates] function result.
    /// </summary>
    public class PhoneNumberCountryStateInfoType
    {
        /// <summary>
        /// The country state code
        /// </summary>
        [JsonProperty("country_state")]
        public string CountryState { get; private set; }

        /// <summary>
        /// The full country state name
        /// </summary>
        [JsonProperty("country_state_name")]
        public string CountryStateName { get; private set; }

    }
}
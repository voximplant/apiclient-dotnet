using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [ChargeAccount] function result.
    /// </summary>
    public class ChargeAccountResult
    {
        /// <summary>
        /// The charged money amount
        /// </summary>
        [JsonProperty("charged_amount")]
        public decimal ChargedAmount { get; private set; }

        /// <summary>
        /// The charged phone list
        /// </summary>
        [JsonProperty("phones")]
        public ChargedPhoneType[] Phones { get; private set; }

    }
}
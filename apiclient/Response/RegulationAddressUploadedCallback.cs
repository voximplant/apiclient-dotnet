using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when proof of address is uploaded. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class RegulationAddressUploadedCallback
    {
        /// <summary>
        /// The uploaded document ID. See GetRegulationsAddress
        /// </summary>
        [JsonProperty("regulation_address_id")]
        public long RegulationAddressId { get; private set; }

        /// <summary>
        /// The UTC date of the document upload in format: YYYY-MM-DD HH::mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("uploaded")]
        public DateTime Uploaded { get; private set; }

        /// <summary>
        /// Whether the account belongs to an individual
        /// </summary>
        [JsonProperty("is_individual")]
        public bool IsIndividual { get; private set; }

        /// <summary>
        /// The regulation address name
        /// </summary>
        [JsonProperty("regulation_address_name")]
        public string RegulationAddressName { get; private set; }

    }
}
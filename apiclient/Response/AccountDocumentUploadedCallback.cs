using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the
    /// [AccountCallback] structure.
    /// </summary>
    public class AccountDocumentUploadedCallback
    {
        /// <summary>
        /// The uploaded document ID. See GetAccountDocuments.
        /// </summary>
        [JsonProperty("account_document_id")]
        public long? AccountDocumentId { get; private set; }

        /// <summary>
        /// The UTC date of the document upload in format: YYYY-MM-DD HH::mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("uploaded")]
        public DateTime? Uploaded { get; private set; }

        /// <summary>
        /// Is individual, isn't legal entity?
        /// </summary>
        [JsonProperty("is_individual")]
        public bool? IsIndividual { get; private set; }

        /// <summary>
        /// The verification name (type).
        /// </summary>
        [JsonProperty("verification_name")]
        public string VerificationName { get; private set; }

    }
}
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Deprecated. Please use the unified [AccountDocumentStatusUpdatedCallback] callback instead.
    /// </summary>
    public class AccountDocumentUploadedCallback
    {
        /// <summary>
        /// The uploaded document ID. See GetAccountDocuments
        /// </summary>
        [JsonProperty("account_document_id")]
        public long AccountDocumentId { get; private set; }

        /// <summary>
        /// The UTC date of the document upload in format: YYYY-MM-DD HH::mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("uploaded")]
        public DateTime Uploaded { get; private set; }

        /// <summary>
        /// The verification name (type)
        /// </summary>
        [JsonProperty("verification_name")]
        public string VerificationName { get; private set; }

        /// <summary>
        /// Status of the user in the context of entrepreneurial activity. Possible values are 'individual', 'entrepreneur', 'legal entity'
        /// </summary>
        [JsonProperty("legal_status")]
        public string LegalStatus { get; private set; }

    }
}
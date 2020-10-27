using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class AccountDocumentVerifiedCallback
    {
        /// <summary>
        /// The uploaded document ID.
        /// </summary>
        [JsonProperty("account_document_id")]
        public long AccountDocumentId { get; private set; }

        /// <summary>
        /// The document verification status. The following values are possible: WAITING_CONFIRMATION_DOCS, VERIFIED, REJECTED.
        /// </summary>
        [JsonProperty("account_document_status")]
        public string AccountDocumentStatus { get; private set; }

        /// <summary>
        /// The UTC date of the document upload in format: YYYY-MM-DD HH::mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("uploaded")]
        public DateTime Uploaded { get; private set; }

        /// <summary>
        /// The reviewer's comment.
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; private set; }

        /// <summary>
        /// The verification name (type).
        /// </summary>
        [JsonProperty("verification_name")]
        public string VerificationName { get; private set; }

        /// <summary>
        /// Status of the user in the context of entrepreneurial activity. Possible values are: 'individual', 'entrepreneur', 'legal entity'.
        /// </summary>
        [JsonProperty("legal_status")]
        public string LegalStatus { get; private set; }

    }
}
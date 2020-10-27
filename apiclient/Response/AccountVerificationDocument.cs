using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The account verification document info. The [AccountVerificationType] field.
    /// </summary>
    public class AccountVerificationDocument
    {
        /// <summary>
        /// The account verification document ID.
        /// </summary>
        [JsonProperty("account_document_id")]
        public long AccountDocumentId { get; private set; }

        /// <summary>
        /// Account belongs to an individual.
        /// </summary>
        [JsonProperty("is_individual")]
        public bool IsIndividual { get; private set; }

        /// <summary>
        /// The reviewer's comment.
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; private set; }

        /// <summary>
        /// The UTC date of the document upload in format: YYYY-MM-DD HH::mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("uploaded")]
        public DateTime Uploaded { get; private set; }

        /// <summary>
        /// The account document status. The following values are possible: ACCEPTED, REJECTED, IN_PROGRESS, INCOMPLETE_SET.
        /// </summary>
        [JsonProperty("account_document_status")]
        public string AccountDocumentStatus { get; private set; }

    }
}
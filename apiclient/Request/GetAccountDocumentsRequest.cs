using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetAccountDocumentsRequest : BaseRequest
    {
        /// <summary>
        /// Set true to view the uploaded document statuses. (The flag is ignored
        /// with the child_account_id=all)
        /// </summary>
        [JsonProperty("with_details")]
        public bool? WithDetails { get; set; }

        /// <summary>
        /// The required account verification name to filter.
        /// </summary>
        [JsonProperty("verification_name")]
        public string VerificationName { get; set; }

        /// <summary>
        /// The account verification status list separated by the ';' symbol. The
        /// following values are possible: REQUIRED, IN_PROGRESS, VERIFIED
        /// </summary>
        [JsonProperty("verification_status")]
        public Argument<string> VerificationStatus { get; set; }

        /// <summary>
        /// Unverified subscriptions hold until the date (from ...) in format:
        /// YYYY-MM-DD
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd")]
        [JsonProperty("from_unverified_hold_until")]
        public DateTime? FromUnverifiedHoldUntil { get; set; }

        /// <summary>
        /// Unverified subscriptions hold until the date (... to) in format:
        /// YYYY-MM-DD
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd")]
        [JsonProperty("to_unverified_hold_until")]
        public DateTime? ToUnverifiedHoldUntil { get; set; }

        /// <summary>
        /// The child account ID list separated by the ';' symbol or the 'all'
        /// value.
        /// </summary>
        [JsonProperty("child_account_id")]
        public Argument<long> ChildAccountId { get; set; }

        /// <summary>
        /// Set true to get the children account verifications only.
        /// </summary>
        [JsonProperty("children_verifications_only")]
        public bool? ChildrenVerificationsOnly { get; set; }

    }
}
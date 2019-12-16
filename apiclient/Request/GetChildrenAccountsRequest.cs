using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetChildrenAccountsRequest : BaseRequest
    {
        /// <summary>
        /// The account ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("child_account_id")]
        public Argument<long> ChildAccountId { get; set; }

        /// <summary>
        /// The child account name part to filter.
        /// </summary>
        [JsonProperty("child_account_name")]
        public string ChildAccountName { get; set; }

        /// <summary>
        /// The child ccount email to filter.
        /// </summary>
        [JsonProperty("child_account_email")]
        public string ChildAccountEmail { get; set; }

        /// <summary>
        /// The active flag to filter.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The frozen flag to filter.
        /// </summary>
        [JsonProperty("frozen")]
        public bool? Frozen { get; set; }

        /// <summary>
        /// Set true to ignore the invalid 'child_account_id' items.
        /// </summary>
        [JsonProperty("ignore_invalid_accounts")]
        public bool? IgnoreInvalidAccounts { get; set; }

        /// <summary>
        /// Set true to output the account_id only.
        /// </summary>
        [JsonProperty("brief_output")]
        public bool? BriefOutput { get; set; }

        /// <summary>
        /// Set true to output the account_id, account_name, account_email only.
        /// </summary>
        [JsonProperty("medium_output")]
        public bool? MediumOutput { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// The following values are available: 'child_account_id',
        /// 'child_account_name' and 'child_account_email'.
        /// </summary>
        [JsonProperty("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Set true to get the user live balance.
        /// </summary>
        [JsonProperty("return_live_balance")]
        public bool? ReturnLiveBalance { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class TransferMoneyToUserRequest : BaseRequest
    {
        /// <summary>
        /// The user ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("user_id")]
        public Argument<long> UserId { get; set; }

        /// <summary>
        /// The user name list separated by the ';' symbol that can be used
        /// instead of <b>user_id</b>.
        /// </summary>
        [JsonProperty("user_name")]
        public Argument<string> UserName { get; set; }

        /// <summary>
        /// The money amount, $. The absolute amount value must be equal or
        /// greater than 0.01
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The application ID. It is required if the <b>user_name</b> is
        /// specified.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name that can be used instead of
        /// <b>application_id</b>.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The amount currency. Examples: RUR, EUR, USD.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Returns error if strict_mode is true and a user or the account hasn't
        /// enough money.
        /// </summary>
        [JsonProperty("strict_mode")]
        public bool? StrictMode { get; set; }

        /// <summary>
        /// The user transaction description.
        /// </summary>
        [JsonProperty("user_transaction_description")]
        public string UserTransactionDescription { get; set; }

        /// <summary>
        /// The account transaction description. The following macro available:
        /// ${user_id}, ${user_name}
        /// </summary>
        [JsonProperty("account_transaction_description")]
        public string AccountTransactionDescription { get; set; }

    }
}
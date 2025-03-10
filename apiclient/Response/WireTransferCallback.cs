using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Received when a wire transfer is made. Received as part of the [AccountCallback] structure.
    /// </summary>
    public class WireTransferCallback
    {
        /// <summary>
        /// The transaction ID
        /// </summary>
        [JsonProperty("transaction_id")]
        public long TransactionId { get; private set; }

        /// <summary>
        /// The transaction type
        /// </summary>
        [JsonProperty("transaction_type")]
        public string TransactionType { get; private set; }

        /// <summary>
        /// The amount in the account currency
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; private set; }

    }
}
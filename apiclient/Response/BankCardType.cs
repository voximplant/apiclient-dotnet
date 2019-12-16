using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The bank card info.
    /// </summary>
    public class BankCardType
    {
        /// <summary>
        /// The auto_charge flag.
        /// </summary>
        [JsonProperty("auto_charge")]
        public bool? AutoCharge { get; private set; }

        /// <summary>
        /// The min account balance to trigger the auto charging.
        /// </summary>
        [JsonProperty("min_balance ")]
        public decimal? MinBalance  { get; private set; }

        /// <summary>
        /// The card overrun value in the account currency.
        /// </summary>
        [JsonProperty("card_overrun_value")]
        public decimal? CardOverrunValue { get; private set; }

        /// <summary>
        /// The card expiration year.
        /// </summary>
        [JsonProperty("expiration_year")]
        public long? ExpirationYear { get; private set; }

        /// <summary>
        /// The card expiration month.
        /// </summary>
        [JsonProperty("expiration_month")]
        public long? ExpirationMonth { get; private set; }

        /// <summary>
        /// The last card number digits.
        /// </summary>
        [JsonProperty("acct")]
        public long? Acct { get; private set; }

        /// <summary>
        /// The last card error.
        /// </summary>
        [JsonProperty("last_error")]
        public BankCardErrorType LastError { get; private set; }

    }
}
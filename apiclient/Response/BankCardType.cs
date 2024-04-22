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
        /// The payment system. The possible values are ALFABANK, BRAINTREE
        /// </summary>
        [JsonProperty("bank_card_provider")]
        public string BankCardProvider { get; private set; }

        /// <summary>
        /// Whether the auto_charge is enabled
        /// </summary>
        [JsonProperty("auto_charge")]
        public bool AutoCharge { get; private set; }

        /// <summary>
        /// The min account balance to trigger the auto charging
        /// </summary>
        [JsonProperty("min_balance ")]
        public decimal MinBalance  { get; private set; }

        /// <summary>
        /// The card overrun value in the account currency
        /// </summary>
        [JsonProperty("card_overrun_value")]
        public decimal CardOverrunValue { get; private set; }

        /// <summary>
        /// The card expiration year
        /// </summary>
        [JsonProperty("expiration_year")]
        public long ExpirationYear { get; private set; }

        /// <summary>
        /// The card expiration month
        /// </summary>
        [JsonProperty("expiration_month")]
        public long ExpirationMonth { get; private set; }

        /// <summary>
        /// The last card number digits
        /// </summary>
        [JsonProperty("acct")]
        public long Acct { get; private set; }

        /// <summary>
        /// The last card error
        /// </summary>
        [JsonProperty("last_error")]
        public BankCardErrorType LastError { get; private set; }

        /// <summary>
        /// The cardholder’s first name and last name
        /// </summary>
        [JsonProperty("card_holder")]
        public string CardHolder { get; private set; }

        /// <summary>
        /// The card's payment system. The possible values are VISA, MASTER CARD
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; private set; }

    }
}
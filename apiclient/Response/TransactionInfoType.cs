using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetTransactionHistory] function result item.
    /// </summary>
    public class TransactionInfoType
    {
        /// <summary>
        /// The transaction ID
        /// </summary>
        [JsonProperty("transaction_id")]
        public long TransactionId { get; private set; }

        /// <summary>
        /// The account ID
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; private set; }

        /// <summary>
        /// The transaction date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("performed_at")]
        public DateTime PerformedAt { get; private set; }

        /// <summary>
        /// The transaction amount, $
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; private set; }

        /// <summary>
        /// The amount currency (USD, RUR, EUR, ...). 
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// The transaction type. The following values are possible: gift_revoke, resource_charge, money_distribution, subscription_charge, subscription_installation_charge, card_periodic_payment, card_overrun_payment, card_payment, rub_card_periodic_payment, rub_card_overrun_payment, rub_card_payment, robokassa_payment, gift, promo, adjustment, wire_transfer, us_wire_transfer, refund, discount, mgp_charge, mgp_startup, mgp_business, mgp_big_business, mgp_enterprise, mgp_large_enterprise, techsupport_charge, tax_charge, monthly_fee_charge, grace_credit_payment, grace_credit_provision, mau_charge, mau_overrun, im_charge, im_overrun, fmc_charge, sip_registration_charge, development_fee, money_transfer_to_child, money_transfer_to_parent, money_acceptance_from_child, money_acceptance_from_parent, phone_number_installation, phone_number_charge, toll_free_phone_number_installation, toll_free_phone_number_charge, services, user_money_transfer, paypal_payment, paypal_overrun_payment, paypal_periodic_payment
        /// </summary>
        [JsonProperty("transaction_type")]
        public string TransactionType { get; private set; }

        /// <summary>
        /// The transaction description
        /// </summary>
        [JsonProperty("transaction_description")]
        public string TransactionDescription { get; private set; }

    }
}
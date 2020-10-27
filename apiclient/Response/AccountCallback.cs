using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The account callback. See the [AccountCallbacks] type.
    /// </summary>
    public class AccountCallback
    {
        /// <summary>
        /// The callback ID (sequence).
        /// </summary>
        [JsonProperty("callback_id")]
        public long CallbackId { get; private set; }

        /// <summary>
        /// The callback type. The following values are possible: account_document_verified, account_is_frozen, account_is_unfrozen, activate_successful, call_history_report, card_expired, card_expires_in_month, card_payment, card_payment_failed, js_fail, min_balance, regulation_address_verified, renewed_subscriptions, reset_account_password_request, sip_registration_fail, stagnant_account, subscription_is_detached, subscription_is_frozen, transaction_history_report, plan_config, unverified_subscription_detached, sms_inbound.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The account ID.
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; private set; }

        /// <summary>
        /// The security hash: hash = md5(account_salt + account_id + api_key + callback_id). Example: 50c5fe2290cd7409b37e673b8b05e495
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; private set; }

        /// <summary>
        /// The account name.
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; private set; }

        /// <summary>
        /// The account email.
        /// </summary>
        [JsonProperty("account_email")]
        public string AccountEmail { get; private set; }

        /// <summary>
        /// The notification language code (2 symbols, ISO639-1). Examples: en, ru
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; private set; }

        /// <summary>
        /// The first name.
        /// </summary>
        [JsonProperty("account_first_name")]
        public string AccountFirstName { get; private set; }

        /// <summary>
        /// The last name.
        /// </summary>
        [JsonProperty("account_last_name")]
        public string AccountLastName { get; private set; }

        /// <summary>
        /// The account's money.
        /// </summary>
        [JsonProperty("balance")]
        public decimal Balance { get; private set; }

        /// <summary>
        /// The currency code (USD, RUR, EUR, ...).
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("account_document_uploaded")]
        public AccountDocumentUploadedCallback AccountDocumentUploaded { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("regulation_address_uploaded")]
        public RegulationAddressUploadedCallback RegulationAddressUploaded { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("account_document_verified")]
        public AccountDocumentVerifiedCallback AccountDocumentVerified { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("account_is_frozen")]
        public AccountIsFrozenCallback AccountIsFrozen { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("account_is_unfrozen")]
        public AccountIsUnfrozenCallback AccountIsUnfrozen { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("activate_successful")]
        public ActivateSuccessfulCallback ActivateSuccessful { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("call_history_report")]
        public CallHistoryReportCallback CallHistoryReport { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("card_expired")]
        public CardExpiredCallback CardExpired { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("card_expires_in_month")]
        public CardExpiresInMonthCallback CardExpiresInMonth { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("card_payment")]
        public CardPaymentCallback CardPayment { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("card_payment_failed")]
        public CardPaymentFailedCallback CardPaymentFailed { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("robokassa_payment")]
        public RobokassaPaymentCallback RobokassaPayment { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("wire_transfer")]
        public WireTransferCallback WireTransfer { get; private set; }

        /// <summary>
        /// The specific account callback details. See the 'send_js_error' parameter of the 'SetAccountInfo' function.
        /// </summary>
        [JsonProperty("js_fail")]
        public JSFailCallback JsFail { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("min_balance")]
        public MinBalanceCallback MinBalance { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("regulation_address_verified")]
        public RegulationAddressVerifiedCallback RegulationAddressVerified { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("renewed_subscriptions")]
        public RenewedSubscriptionsCallback RenewedSubscriptions { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("reset_account_password_request")]
        public ResetAccountPasswordRequestCallback ResetAccountPasswordRequest { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("sip_registration_fail")]
        public SIPRegistrationFailCallback SipRegistrationFail { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("stagnant_account")]
        public StagnantAccountCallback StagnantAccount { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("subscription_is_frozen")]
        public SubscriptionIsFrozenCallback SubscriptionIsFrozen { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("subscription_is_detached")]
        public SubscriptionIsDetachedCallback SubscriptionIsDetached { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("transaction_history_report")]
        public TransactionHistoryReportCallback TransactionHistoryReport { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("plan_config")]
        public PlanConfigCallback PlanConfig { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("unverified_subscription_detached")]
        public UnverifiedSubscriptionDetachedCallback UnverifiedSubscriptionDetached { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("expiring_callerid")]
        public ExpiringCallerIDCallback ExpiringCallerid { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("transcription_complete")]
        public TranscriptionCompleteCallback TranscriptionComplete { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("sms_inbound")]
        public InboundSmsCallback SmsInbound { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("new_invoice")]
        public NewInvoiceCallback NewInvoice { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("expiring_agreement")]
        public ExpiringAgreementCallback ExpiringAgreement { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("expired_agreement")]
        public ExpiredAgreementCallback ExpiredAgreement { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("restored_agreement_status")]
        public RestoredAgreementStatusCallback RestoredAgreementStatus { get; private set; }

        /// <summary>
        /// The specific account callback details.
        /// </summary>
        [JsonProperty("balance_is_changed")]
        public BalanceIsChanged BalanceIsChanged { get; private set; }

    }
}
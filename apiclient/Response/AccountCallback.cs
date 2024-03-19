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
        /// The callback ID (sequence)
        /// </summary>
        [JsonProperty("callback_id")]
        public long CallbackId { get; private set; }

        /// <summary>
        /// The callback type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The account ID
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; private set; }

        /// <summary>
        /// The security hash: hash = md5(account_salt + account_id + api_key + callback_id). Example: 50c5fe2290cd7409b37e673b8b05e495
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; private set; }

        /// <summary>
        /// The account name
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; private set; }

        /// <summary>
        /// The account email
        /// </summary>
        [JsonProperty("account_email")]
        public string AccountEmail { get; private set; }

        /// <summary>
        /// The notification language code (2 symbols, ISO639-1). Examples: en, ru
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; private set; }

        /// <summary>
        /// The first name
        /// </summary>
        [JsonProperty("account_first_name")]
        public string AccountFirstName { get; private set; }

        /// <summary>
        /// The last name
        /// </summary>
        [JsonProperty("account_last_name")]
        public string AccountLastName { get; private set; }

        /// <summary>
        /// The account's money
        /// </summary>
        [JsonProperty("balance")]
        public decimal Balance { get; private set; }

        /// <summary>
        /// The currency code (USD, RUR, EUR, ...)
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Deprecated. Please use the unified <b>account_document_status_updated</b> callback instead
        /// </summary>
        [JsonProperty("account_document_uploaded")]
        public AccountDocumentUploadedCallback AccountDocumentUploaded { get; private set; }

        /// <summary>
        /// Received when proof of address is uploaded
        /// </summary>
        [JsonProperty("regulation_address_uploaded")]
        public RegulationAddressUploadedCallback RegulationAddressUploaded { get; private set; }

        /// <summary>
        /// Deprecated. Please use the unified <b>account_document_status_updated</b> callback instead
        /// </summary>
        [JsonProperty("account_document_verified")]
        public AccountDocumentVerifiedCallback AccountDocumentVerified { get; private set; }

        /// <summary>
        /// Received when an account is frozen
        /// </summary>
        [JsonProperty("account_is_frozen")]
        public AccountIsFrozenCallback AccountIsFrozen { get; private set; }

        /// <summary>
        /// Received when an account is unfrozen
        /// </summary>
        [JsonProperty("account_is_unfrozen")]
        public AccountIsUnfrozenCallback AccountIsUnfrozen { get; private set; }

        /// <summary>
        /// Received when a new (not child) account is created
        /// </summary>
        [JsonProperty("activate_successful")]
        public ActivateSuccessfulCallback ActivateSuccessful { get; private set; }

        /// <summary>
        /// Received when a call history report is ready
        /// </summary>
        [JsonProperty("call_history_report")]
        public CallHistoryReportCallback CallHistoryReport { get; private set; }

        /// <summary>
        /// Received when a card is expired
        /// </summary>
        [JsonProperty("card_expired")]
        public CardExpiredCallback CardExpired { get; private set; }

        /// <summary>
        /// Received when one month is left for a card to be expired
        /// </summary>
        [JsonProperty("card_expires_in_month")]
        public CardExpiresInMonthCallback CardExpiresInMonth { get; private set; }

        /// <summary>
        /// Received when a bank card payment is made
        /// </summary>
        [JsonProperty("card_payment")]
        public CardPaymentCallback CardPayment { get; private set; }

        /// <summary>
        /// Received when a bank card payment is failed
        /// </summary>
        [JsonProperty("card_payment_failed")]
        public CardPaymentFailedCallback CardPaymentFailed { get; private set; }

        /// <summary>
        /// Received when a robokassa payment is made
        /// </summary>
        [JsonProperty("robokassa_payment")]
        public RobokassaPaymentCallback RobokassaPayment { get; private set; }

        /// <summary>
        /// Received when a wire transfer is made
        /// </summary>
        [JsonProperty("wire_transfer")]
        public WireTransferCallback WireTransfer { get; private set; }

        /// <summary>
        /// Received when <b>send_js_error</b> is set to true and a JS error occurs. See the 'send_js_error' parameter of the 'SetAccountInfo' function
        /// </summary>
        [JsonProperty("js_fail")]
        public JSFailCallback JsFail { get; private set; }

        /// <summary>
        /// Received when the minimum balance is reached
        /// </summary>
        [JsonProperty("min_balance")]
        public MinBalanceCallback MinBalance { get; private set; }

        /// <summary>
        /// Received when proof of address is verified
        /// </summary>
        [JsonProperty("regulation_address_verified")]
        public RegulationAddressVerifiedCallback RegulationAddressVerified { get; private set; }

        /// <summary>
        /// Received when subscriptions are renewed
        /// </summary>
        [JsonProperty("renewed_subscriptions")]
        public RenewedSubscriptionsCallback RenewedSubscriptions { get; private set; }

        /// <summary>
        /// Received when an account password reset is requested
        /// </summary>
        [JsonProperty("reset_account_password_request")]
        public ResetAccountPasswordRequestCallback ResetAccountPasswordRequest { get; private set; }

        /// <summary>
        /// Received when one or several SIP registrations are failed
        /// </summary>
        [JsonProperty("sip_registration_fail")]
        public SIPRegistrationFailCallback SipRegistrationFail { get; private set; }

        /// <summary>
        /// Received when one or several SIP registrations are recovered
        /// </summary>
        [JsonProperty("sip_registration_recovered")]
        public SIPRegistrationRecoveredCallback SipRegistrationRecovered { get; private set; }

        /// <summary>
        /// Received when a subscription is frozen
        /// </summary>
        [JsonProperty("subscription_is_frozen")]
        public SubscriptionIsFrozenCallback SubscriptionIsFrozen { get; private set; }

        /// <summary>
        /// Received when a subscription is canceled
        /// </summary>
        [JsonProperty("subscription_is_detached")]
        public SubscriptionIsDetachedCallback SubscriptionIsDetached { get; private set; }

        /// <summary>
        /// Received when a transaction history report is ready
        /// </summary>
        [JsonProperty("transaction_history_report")]
        public TransactionHistoryReportCallback TransactionHistoryReport { get; private set; }

        /// <summary>
        /// Received when an unverified subscription is canceled
        /// </summary>
        [JsonProperty("unverified_subscription_detached")]
        public UnverifiedSubscriptionDetachedCallback UnverifiedSubscriptionDetached { get; private set; }

        /// <summary>
        /// Received when a caller ID is about to be expired
        /// </summary>
        [JsonProperty("expiring_callerid")]
        public ExpiringCallerIDCallback ExpiringCallerid { get; private set; }

        /// <summary>
        /// Received when a transcription is saved
        /// </summary>
        [JsonProperty("transcription_complete")]
        public TranscriptionCompleteCallback TranscriptionComplete { get; private set; }

        /// <summary>
        /// Received when an incoming SMS is gotten
        /// </summary>
        [JsonProperty("sms_inbound")]
        public InboundSmsCallback SmsInbound { get; private set; }

        /// <summary>
        /// Received for the accounts for which the confirmation documents waiting period expires in 20/15/10/5/1 day(s)
        /// </summary>
        [JsonProperty("expiring_agreement")]
        public ExpiringAgreementCallback ExpiringAgreement { get; private set; }

        /// <summary>
        /// Received for the accounts for which the confirmation documents waiting period has already expired or expires today
        /// </summary>
        [JsonProperty("expired_agreement")]
        public ExpiredAgreementCallback ExpiredAgreement { get; private set; }

        /// <summary>
        /// Received when an expiration date of the confirmation documents waiting period is changed
        /// </summary>
        [JsonProperty("restored_agreement_status")]
        public RestoredAgreementStatusCallback RestoredAgreementStatus { get; private set; }

        /// <summary>
        /// Received when a plan is to be renewed in 3 days, but there is not enough money
        /// </summary>
        [JsonProperty("next_charge_alert")]
        public NextChargeAlertCallback NextChargeAlert { get; private set; }

        /// <summary>
        /// Deprecated. Please use the <b>expired_certificates</b> and <b>expiring_certificates</b> callbacks instead
        /// </summary>
        [JsonProperty("certificate_expired")]
        public CertificateExpiredCallback CertificateExpired { get; private set; }

        /// <summary>
        /// Received for the accounts whose Apple VOIP certificates are expired
        /// </summary>
        [JsonProperty("expired_certificates")]
        public ExpiredCertificateCallback ExpiredCertificates { get; private set; }

        /// <summary>
        /// Received for the accounts whose Apple VOIP certificates expire in 14 or fewer days
        /// </summary>
        [JsonProperty("expiring_certificates")]
        public ExpiringCertificateCallback ExpiringCertificates { get; private set; }

        /// <summary>
        /// Received when the verification status is updated
        /// </summary>
        [JsonProperty("account_document_status_updated")]
        public AccountDocumentStatusUpdatedCallback AccountDocumentStatusUpdated { get; private set; }

        /// <summary>
        /// Received when A2P SMS are activated
        /// </summary>
        [JsonProperty("a2p_sms_activated")]
        public A2PActivatedCallback A2pSmsActivated { get; private set; }

        /// <summary>
        /// Received when the verification status is changed to PENDING
        /// </summary>
        [JsonProperty("regulation_address_documents_requested")]
        public RegulationAddressDocumentsRequestedCallback RegulationAddressDocumentsRequested { get; private set; }

        /// <summary>
        /// Received when a monthly invoice is sent
        /// </summary>
        [JsonProperty("invoice_received")]
        public InvoiceReceivedCallback InvoiceReceived { get; private set; }

    }
}
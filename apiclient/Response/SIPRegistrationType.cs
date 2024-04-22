using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Detailing SIP registration.
    /// </summary>
    public class SIPRegistrationType
    {
        /// <summary>
        /// The SIP registration ID
        /// </summary>
        [JsonProperty("sip_registration_id")]
        public long SipRegistrationId { get; private set; }

        /// <summary>
        /// The user name from sip proxy
        /// </summary>
        [JsonProperty("sip_username")]
        public string SipUsername { get; private set; }

        /// <summary>
        /// The sip proxy
        /// </summary>
        [JsonProperty("proxy")]
        public string Proxy { get; private set; }

        /// <summary>
        /// The last time updated
        /// </summary>
        [JsonProperty("last_updated")]
        public long LastUpdated { get; private set; }

        /// <summary>
        /// The SIP authentications user
        /// </summary>
        [JsonProperty("auth_user")]
        public string AuthUser { get; private set; }

        /// <summary>
        /// The outgoing proxy
        /// </summary>
        [JsonProperty("outbound_proxy")]
        public string OutboundProxy { get; private set; }

        /// <summary>
        /// Whether the SIP registration is successful
        /// </summary>
        [JsonProperty("successful")]
        public bool? Successful { get; private set; }

        /// <summary>
        /// The status code from a SIP registration
        /// </summary>
        [JsonProperty("status_code")]
        public long? StatusCode { get; private set; }

        /// <summary>
        /// The error message from a SIP registration
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Whether the subscription is deactivation. The SIP registration is frozen if true
        /// </summary>
        [JsonProperty("deactivated")]
        public bool Deactivated { get; private set; }

        /// <summary>
        /// The next subscription renewal date in format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("next_subscription_renewal")]
        public DateTime NextSubscriptionRenewal { get; private set; }

        /// <summary>
        /// The purchase date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("purchase_date")]
        public DateTime PurchaseDate { get; private set; }

        /// <summary>
        /// The subscription monthly charge
        /// </summary>
        [JsonProperty("subscription_price")]
        public string SubscriptionPrice { get; private set; }

        /// <summary>
        /// Whether the SIP registration is persistent. Set false to activate it only on the user login
        /// </summary>
        [JsonProperty("is_persistent")]
        public bool IsPersistent { get; private set; }

        /// <summary>
        /// The id of the bound user
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; private set; }

        /// <summary>
        /// The name of the bound user
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; private set; }

        /// <summary>
        /// The id of the bound application
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; private set; }

        /// <summary>
        /// The name of the bound application
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; private set; }

        /// <summary>
        /// The id of the bound rule
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; private set; }

        /// <summary>
        /// The name of the bound rule
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; private set; }

    }
}
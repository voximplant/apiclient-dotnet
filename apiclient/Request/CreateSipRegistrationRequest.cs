using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class CreateSipRegistrationRequest : BaseRequest
    {
        /// <summary>
        /// The user name.
        /// </summary>
        [JsonProperty("sip_username")]
        public string SipUsername { get; set; }

        /// <summary>
        /// The SIP proxy
        /// </summary>
        [JsonProperty("proxy")]
        public string Proxy { get; set; }

        /// <summary>
        /// The SIP authentications user
        /// </summary>
        [JsonProperty("auth_user")]
        public string AuthUser { get; set; }

        /// <summary>
        /// The outbound SIP proxy
        /// </summary>
        [JsonProperty("outbound_proxy")]
        public string OutboundProxy { get; set; }

        /// <summary>
        /// The SIP password
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Is SIP registration persistent or on the user logon?
        /// </summary>
        [JsonProperty("is_persistent")]
        public bool? IsPersistent { get; set; }

        /// <summary>
        /// The application ID which new SIP registration will be bound to. Could
        /// be used instead of the <b>application_name</b> parameter.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name which new SIP registration will be bound to.
        /// Could be used instead of the <b>application_id</b> parameter.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The rule ID which new SIP registration will be bound to. Could be
        /// used instead of the <b>rule_name</b> parameter.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; set; }

        /// <summary>
        /// The rule name which new SIP registration will be bound to. Could be
        /// used instead of the <b>rule_id</b> parameter.
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// The user ID which new SIP registration will be bound to. Could be
        /// used instead of the <b>user_name</b> parameter.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// The user name which new SIP registration will be bound to. Could be
        /// used instead of the <b>user_id</b> parameter.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }

    }
}
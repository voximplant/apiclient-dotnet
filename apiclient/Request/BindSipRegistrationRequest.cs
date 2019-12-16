using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class BindSipRegistrationRequest : BaseRequest
    {
        /// <summary>
        /// The registration ID
        /// </summary>
        [JsonProperty("sip_registration_id")]
        public long? SipRegistrationId { get; set; }

        /// <summary>
        /// The application ID which the SIP registration will be bound to. Could
        /// be used instead of the <b>application_name</b> parameter.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name which the SIP registration will be bound to.
        /// Could be used instead of the <b>application_id</b> parameter.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The rule ID which the SIP registration will be bound to. Could be
        /// used instead of the <b>rule_name</b> parameter.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; set; }

        /// <summary>
        /// The rule name which the SIP registration will be bound to. Could be
        /// used instead of the <b>rule_id</b> parameter.
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// The user ID which the SIP registration will be bound to. Could be
        /// used instead of the <b>user_name</b> parameter.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// The user name which the SIP registration will be bound to. Could be
        /// used instead of the <b>user_id</b> parameter.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// Bind or unbind?
        /// </summary>
        [JsonProperty("bind")]
        public bool? Bind { get; set; }

    }
}
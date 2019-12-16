using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class BindPhoneNumberToApplicationRequest : BaseRequest
    {
        /// <summary>
        /// The phone ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("phone_id")]
        public Argument<long> PhoneId { get; set; }

        /// <summary>
        /// The phone number list separated by the ';' symbol that can be used
        /// instead of <b>phone_id</b>.
        /// </summary>
        [JsonProperty("phone_number")]
        public Argument<string> PhoneNumber { get; set; }

        /// <summary>
        /// The application ID.
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
        /// The rule ID.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; set; }

        /// <summary>
        /// The rule name that can be used instead of <b>rule_id</b>.
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// Bind or unbind?
        /// </summary>
        [JsonProperty("bind")]
        public bool? Bind { get; set; }

    }
}
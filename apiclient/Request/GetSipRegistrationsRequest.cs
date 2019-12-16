using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetSipRegistrationsRequest : BaseRequest
    {
        /// <summary>
        /// The SIP registration ID.
        /// </summary>
        [JsonProperty("sip_registration_id")]
        public long? SipRegistrationId { get; set; }

        /// <summary>
        /// The SIP user name to filter.
        /// </summary>
        [JsonProperty("sip_username")]
        public string SipUsername { get; set; }

        /// <summary>
        /// Set true to show the frozen SIP registrations only.
        /// </summary>
        [JsonProperty("deactivated")]
        public bool? Deactivated { get; set; }

        /// <summary>
        /// Set false to show the unsuccessful SIP registrations only.
        /// </summary>
        [JsonProperty("successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// The persistent flag to filter.
        /// </summary>
        [JsonProperty("is_persistent")]
        public bool? IsPersistent { get; set; }

        /// <summary>
        /// The application ID list separated by the ';' symbol to filter. Can be
        /// used instead of <b>appliction_name</b>.
        /// </summary>
        [JsonProperty("application_id")]
        public Argument<long> ApplicationId { get; set; }

        /// <summary>
        /// The application name list separated by the ';' symbol to filter. Can
        /// be used instead of <b>appliction_id</b>.
        /// </summary>
        [JsonProperty("application_name")]
        public Argument<string> ApplicationName { get; set; }

        /// <summary>
        /// Is a SIP registration bound to an application.
        /// </summary>
        [JsonProperty("is_bound_to_application")]
        public bool? IsBoundToApplication { get; set; }

        /// <summary>
        /// The rule ID list separated by the ';' symbol to filter. Can be used
        /// instead of <b>rule_name</b>.
        /// </summary>
        [JsonProperty("rule_id")]
        public Argument<long> RuleId { get; set; }

        /// <summary>
        /// The rule name list separated by the ';' symbol to filter. Can be used
        /// instead of <b>rule_id</b>.
        /// </summary>
        [JsonProperty("rule_name")]
        public Argument<string> RuleName { get; set; }

        /// <summary>
        /// The user ID list separated by the ';' symbol to filter. Can be used
        /// instead of <b>user_name</b>.
        /// </summary>
        [JsonProperty("user_id")]
        public Argument<long> UserId { get; set; }

        /// <summary>
        /// The user name list separated by the ';' symbol to filter. Can be used
        /// instead of <b>user_id</b>.
        /// </summary>
        [JsonProperty("user_name")]
        public Argument<string> UserName { get; set; }

        /// <summary>
        /// The list of proxy servers to use, divided by the ';' symbol.
        /// </summary>
        [JsonProperty("proxy")]
        public Argument<string> Proxy { get; set; }

        /// <summary>
        /// Is the SIP registration is still in progress or not?
        /// </summary>
        [JsonProperty("in_progress")]
        public bool? InProgress { get; set; }

        /// <summary>
        /// The list of SIP response codes. The __code1:code2__ means a range
        /// from __code1__ to __code2__ including; the __code1;code2__ meanse
        /// either __code1__ or __code2__. You can combine ranges, e.g.,
        /// __code1;code2:code3__.
        /// </summary>
        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

    }
}
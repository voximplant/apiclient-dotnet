using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class BindPushCredentialRequest : BaseRequest
    {
        /// <summary>
        /// The push credentials ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("push_credential_id")]
        public Argument<long> PushCredentialId { get; set; }

        /// <summary>
        /// The application ID list separated by the ';' symbol or the 'all'
        /// value.
        /// </summary>
        [JsonProperty("application_id")]
        public Argument<long> ApplicationId { get; set; }

        /// <summary>
        /// Set to false for unbind. Default value is true.
        /// </summary>
        [JsonProperty("bind")]
        public bool? Bind { get; set; }

    }
}
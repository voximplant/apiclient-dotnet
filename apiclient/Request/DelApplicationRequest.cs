using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelApplicationRequest : BaseRequest
    {
        /// <summary>
        /// The application ID list separated by the ';' symbol or the 'all'
        /// value.
        /// </summary>
        [JsonProperty("application_id")]
        public Argument<long> ApplicationId { get; set; }

        /// <summary>
        /// The application name list separated by the ';' symbol. Can be used
        /// instead of <b>appliction_id</b>.
        /// </summary>
        [JsonProperty("application_name")]
        public Argument<string> ApplicationName { get; set; }

    }
}
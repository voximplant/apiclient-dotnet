using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetApplicationsRequest : BaseRequest
    {
        /// <summary>
        /// The application ID to filter.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name part to filter.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The user ID to filter.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// The excluded user ID to filter.
        /// </summary>
        [JsonProperty("excluded_user_id")]
        public long? ExcludedUserId { get; set; }

        /// <summary>
        /// Specify the user ID value to show it in the 'users' array output.
        /// </summary>
        [JsonProperty("showing_user_id")]
        public long? ShowingUserId { get; set; }

        /// <summary>
        /// Set true to get bound rules info.
        /// </summary>
        [JsonProperty("with_rules")]
        public bool? WithRules { get; set; }

        /// <summary>
        /// Set true to get bound rules and scenarios info.
        /// </summary>
        [JsonProperty("with_scenarios")]
        public bool? WithScenarios { get; set; }

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
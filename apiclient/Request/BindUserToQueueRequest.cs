using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class BindUserToQueueRequest : BaseRequest
    {
        /// <summary>
        /// Bind or unbind users.
        /// </summary>
        [JsonProperty("bind")]
        public bool? Bind { get; set; }

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
        /// The user ID list separated by the ';' symbol or the 'all' value to
        /// specify all users bound to the application.
        /// </summary>
        [JsonProperty("user_id")]
        public Argument<long> UserId { get; set; }

        /// <summary>
        /// The user name that can be used instead of <b>user_id</b>. The user
        /// name list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("user_name")]
        public Argument<string> UserName { get; set; }

        /// <summary>
        /// The ACD queue ID list separated by the ';' symbol or the 'all' value
        /// to specify all queues bound to the application.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public Argument<long> AcdQueueId { get; set; }

        /// <summary>
        /// The queue name that can be used instead of <b>acd_queue_id</b>. The
        /// queue name list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("acd_queue_name")]
        public Argument<string> AcdQueueName { get; set; }

    }
}
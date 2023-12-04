using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetCallHistory] function result item.
    /// </summary>
    public class CallSessionInfoType
    {
        /// <summary>
        /// The routing rule name
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; private set; }

        /// <summary>
        /// The application name
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; private set; }

        /// <summary>
        /// The unique JS session identifier
        /// </summary>
        [JsonProperty("call_session_history_id")]
        public long CallSessionHistoryId { get; private set; }

        /// <summary>
        /// The account ID that initiates the JS session
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; private set; }

        /// <summary>
        /// The application ID that initiates the JS session
        /// </summary>
        [JsonProperty("application_id")]
        public long ApplicationId { get; private set; }

        /// <summary>
        /// The user ID that initiates the JS session
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; private set; }

        /// <summary>
        /// The start date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("start_date")]
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// The entire JS session duration in seconds. The session can contain multiple calls
        /// </summary>
        [JsonProperty("duration")]
        public long? Duration { get; private set; }

        /// <summary>
        /// The initiator IP address
        /// </summary>
        [JsonProperty("initiator_address")]
        public string InitiatorAddress { get; private set; }

        /// <summary>
        /// The media server IP address
        /// </summary>
        [JsonProperty("media_server_address")]
        public string MediaServerAddress { get; private set; }

        /// <summary>
        /// The link to the session log. The log retention policy is 1 month, after that time this field clears. If you have issues accessing the log file, check if the application has "Secure storage of applications and logs" feature enabled. In this case, you need to <a href='/docs/guides/managementapi/secureobjects'>authorize</a>.
        /// </summary>
        [JsonProperty("log_file_url")]
        public string LogFileUrl { get; private set; }

        /// <summary>
        /// The finish reason. Possible values are __Normal termination__, __Insufficient funds__, __Internal error (billing timeout)__, __Terminated administratively__, __JS session error__, __Timeout__
        /// </summary>
        [JsonProperty("finish_reason")]
        public string FinishReason { get; private set; }

        /// <summary>
        /// The calls within JS session, including durations, cost, phone numbers and other information
        /// </summary>
        [JsonProperty("calls")]
        public CallInfoType[] Calls { get; private set; }

        /// <summary>
        /// The used resorces
        /// </summary>
        [JsonProperty("other_resource_usage")]
        public ResourceUsageType[] OtherResourceUsage { get; private set; }

        /// <summary>
        /// The bound records
        /// </summary>
        [JsonProperty("records")]
        public RecordType[] Records { get; private set; }

        /// <summary>
        /// The custom data
        /// </summary>
        [JsonProperty("custom_data")]
        public string CustomData { get; private set; }

    }
}
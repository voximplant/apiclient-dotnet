using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetAuditLog] function result item.
    /// </summary>
    public class AuditLogInfoType
    {
        /// <summary>
        /// The audit log ID
        /// </summary>
        [JsonProperty("audit_log_id")]
        public long AuditLogId { get; private set; }

        /// <summary>
        /// The subuser's ID
        /// </summary>
        [JsonProperty("subuser_id")]
        public long? SubuserId { get; private set; }

        /// <summary>
        /// The subuser's name
        /// </summary>
        [JsonProperty("subuser_name")]
        public string SubuserName { get; private set; }

        /// <summary>
        /// The account ID
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; private set; }

        /// <summary>
        /// The action time in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("requested")]
        public DateTime Requested { get; private set; }

        /// <summary>
        /// The initiator IP address
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; private set; }

        /// <summary>
        /// The called function
        /// </summary>
        [JsonProperty("cmd_name")]
        public string CmdName { get; private set; }

        /// <summary>
        /// The arguments of the called function (they may be masked or resolved)
        /// </summary>
        [JsonProperty("cmd_args")]
        public object CmdArgs { get; private set; }

        /// <summary>
        /// The modified values
        /// </summary>
        [JsonProperty("cmd_result")]
        public object CmdResult { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetUsers] function result.
    /// </summary>
    public class UserInfoType
    {
        /// <summary>
        /// The user ID
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; private set; }

        /// <summary>
        /// The user name
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; private set; }

        /// <summary>
        /// The display user name
        /// </summary>
        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; private set; }

        /// <summary>
        /// The user active flag
        /// </summary>
        [JsonProperty("user_active")]
        public bool UserActive { get; private set; }

        /// <summary>
        /// 'True' if the user uses the parent account's money, 'false' if the user has a separate balance
        /// </summary>
        [JsonProperty("parent_accounting")]
        public bool ParentAccounting { get; private set; }

        /// <summary>
        /// The current user's money in the currency specified for the account. The value is the number rounded to 4 decimal places and it changes during the calls, transcribing, purchases etc
        /// </summary>
        [JsonProperty("live_balance")]
        public decimal LiveBalance { get; private set; }

        /// <summary>
        /// The current user's money in the currency specified for the account. The value is the number rounded to 4 decimal places. The parameter is the alias to live_balance by default. But there is a possibility to make the alias to fixed_balance: just to pass return_live_balance=false into the [GetAccountInfo] method
        /// </summary>
        [JsonProperty("balance")]
        public decimal Balance { get; private set; }

        /// <summary>
        /// The last committed balance which was approved by billing's transaction
        /// </summary>
        [JsonProperty("fixed_balance")]
        public decimal FixedBalance { get; private set; }

        /// <summary>
        /// The custom data
        /// </summary>
        [JsonProperty("user_custom_data")]
        public string UserCustomData { get; private set; }

        /// <summary>
        /// The bound applications
        /// </summary>
        [JsonProperty("applications")]
        public ApplicationInfoType[] Applications { get; private set; }

        /// <summary>
        /// The bound skills
        /// </summary>
        [JsonProperty("skills")]
        public SkillInfoType[] Skills { get; private set; }

        /// <summary>
        /// The bound ACD queues
        /// </summary>
        [JsonProperty("acd_queues")]
        public ACDQueueOperatorInfoType[] AcdQueues { get; private set; }

        /// <summary>
        /// The ACD operator status. The following values are possible: OFFLINE, ONLINE, READY, BANNED, IN_SERVICE, AFTER_SERVICE, TIMEOUT, DND
        /// </summary>
        [JsonProperty("acd_status")]
        public string AcdStatus { get; private set; }

        /// <summary>
        /// The ACD status changing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("acd_status_change_time")]
        public DateTime AcdStatusChangeTime { get; private set; }

        /// <summary>
        /// The user editing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; private set; }

        /// <summary>
        /// The user editing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("modified")]
        public DateTime Modified { get; private set; }

    }
}
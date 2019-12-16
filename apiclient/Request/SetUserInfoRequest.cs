using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetUserInfoRequest : BaseRequest
    {
        /// <summary>
        /// The user to edit.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// Can be used instead of <b>user_id</b>.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// The application ID. It is required if the <b>user_name</b> is
        /// specified.
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
        /// The new user name in format [a-z0-9][a-z0-9_-]{2,49}
        /// </summary>
        [JsonProperty("new_user_name")]
        public string NewUserName { get; set; }

        /// <summary>
        /// The new user display name. The length must be less than 256.
        /// </summary>
        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// The new user password. The length must be at least 6 symbols.
        /// </summary>
        [JsonProperty("user_password")]
        public string UserPassword { get; set; }

        /// <summary>
        /// Set 'true' to use the parent account's money, 'false' to use a
        /// separate user balance.
        /// </summary>
        [JsonProperty("parent_accounting")]
        public bool? ParentAccounting { get; set; }

        /// <summary>
        /// The user enable flag
        /// </summary>
        [JsonProperty("user_active")]
        public bool? UserActive { get; set; }

        /// <summary>
        /// Any string
        /// </summary>
        [JsonProperty("user_custom_data")]
        public string UserCustomData { get; set; }

        /// <summary>
        /// The new user mobile phone. The length must be less than 50.
        /// </summary>
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }

    }
}
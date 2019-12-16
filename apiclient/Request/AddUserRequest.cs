using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddUserRequest : BaseRequest
    {
        /// <summary>
        /// The user name in format [a-z0-9][a-z0-9_-]{2,49}
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// The user display name. The length must be less than 256.
        /// </summary>
        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// The user password. The length must be at least 6 symbols.
        /// </summary>
        [JsonProperty("user_password")]
        public string UserPassword { get; set; }

        /// <summary>
        /// The application ID which new user will be bound to. Could be used
        /// instead of the <b>application_name</b> parameter.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name which new user will be bound to. Could be used
        /// instead of the <b>application_id</b> parameter.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// 'True' if the user will use the parent account's money, 'false' if
        /// the user will have a separate balance.
        /// </summary>
        [JsonProperty("parent_accounting")]
        public bool? ParentAccounting { get; set; }

        /// <summary>
        /// The user mobile phone. The length must be less than 50.
        /// </summary>
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }

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

    }
}
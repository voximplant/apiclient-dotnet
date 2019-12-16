using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class StartScenariosRequest : BaseRequest
    {
        /// <summary>
        /// The user ID. Run the scripts from the user if set.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// The user name that can be used instead of <b>user_id</b>. Run the
        /// scripts from the user if set.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }

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
        /// The rule ID.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; set; }

        /// <summary>
        /// The script custom data (like a script argument). Can be accessed in
        /// JS scenario via the <a
        /// href='//voximplant.com/docs/references/voxengine/voxengine#customdata'>VoxEngine.customData()</a>
        /// method
        /// </summary>
        [JsonProperty("script_custom_data")]
        public string ScriptCustomData { get; set; }

        /// <summary>
        /// Specifies the IP from the geolocation of predicted subscribers. It
        /// allows selecting the nearest server for serving subscribers.
        /// </summary>
        [JsonProperty("reference_ip")]
        public string ReferenceIp { get; set; }

        /// <summary>
        /// Set true to get media server session lists url.
        /// </summary>
        [JsonProperty("with_check_url")]
        public bool? WithCheckUrl { get; set; }

    }
}
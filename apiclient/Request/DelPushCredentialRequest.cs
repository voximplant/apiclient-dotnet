using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelPushCredentialRequest : BaseRequest
    {
        /// <summary>
        /// The push credentials id.
        /// </summary>
        [JsonProperty("push_credential_id")]
        public long? PushCredentialId { get; set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [CreateKey] function result.
    /// </summary>
    public class KeyInfo
    {
        /// <summary>
        /// Client email.
        /// </summary>
        [JsonProperty("account_email")]
        public string AccountEmail { get; private set; }

        /// <summary>
        /// The account ID.
        /// </summary>
        [JsonProperty("account_id")]
        public long? AccountId { get; private set; }

        /// <summary>
        /// The key ID.
        /// </summary>
        [JsonProperty("key_id")]
        public string KeyId { get; private set; }

        /// <summary>
        /// The private key.
        /// </summary>
        [JsonProperty("private_key")]
        public string PrivateKey { get; private set; }

    }
}
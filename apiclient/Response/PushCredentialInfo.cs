using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The push credentials list item info.
    /// </summary>
    public class PushCredentialInfo
    {
        /// <summary>
        /// The push credential id
        /// </summary>
        [JsonProperty("push_credential_id")]
        public long? PushCredentialId { get; private set; }

        /// <summary>
        /// The push provider id
        /// </summary>
        [JsonProperty("push_provider_id")]
        public long? PushProviderId { get; private set; }

        /// <summary>
        /// The push provider name. The possible values are: APPLE, APPLE_VOIP,
        /// GOOGLE
        /// </summary>
        [JsonProperty("push_provider_name")]
        public string PushProviderName { get; private set; }

        /// <summary>
        /// The bundle of Android/iOS application.
        /// </summary>
        [JsonProperty("credential_bundle")]
        public string CredentialBundle { get; private set; }

        /// <summary>
        /// The credentials content.
        /// </summary>
        [JsonProperty("content")]
        public PushCredentialContent Content { get; private set; }

        /// <summary>
        /// Bound applications.
        /// </summary>
        [JsonProperty("applications")]
        public IReadOnlyList<ApplicationInfoType> Applications { get; private set; }

    }
}
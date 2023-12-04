using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The notification contact info.
    /// </summary>
    public class ContactInfoType
    {
        /// <summary>
        /// The contact ID
        /// </summary>
        [JsonProperty("contact_id")]
        public long ContactId { get; private set; }

        /// <summary>
        /// The contact type. The following values are available: 'email'
        /// </summary>
        [JsonProperty("contact_type")]
        public string ContactType { get; private set; }

        /// <summary>
        /// The contact data (i.g. email)
        /// </summary>
        [JsonProperty("contact_data")]
        public string ContactData { get; private set; }

        /// <summary>
        /// The persistent flag
        /// </summary>
        [JsonProperty("is_persistent")]
        public bool IsPersistent { get; private set; }

        /// <summary>
        /// The contact description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The verification code sending timeout is seconds
        /// </summary>
        [JsonProperty("next_verification_after_sec")]
        public long? NextVerificationAfterSec { get; private set; }

        /// <summary>
        /// The activation time in the UTC timezone in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("verified")]
        public DateTime? Verified { get; private set; }

        /// <summary>
        /// The attached notification group list. The following groups are available: 'news', 'tariff_changing', 'account', 'development'
        /// </summary>
        [JsonProperty("notification_group")]
        public string[] NotificationGroup { get; private set; }

        /// <summary>
        /// The creation time in the UTC timezone in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; private set; }

        /// <summary>
        /// The contact editing UTC date in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("modified")]
        public DateTime Modified { get; private set; }

    }
}
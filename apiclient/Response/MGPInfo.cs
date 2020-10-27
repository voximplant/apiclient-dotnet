using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetActiveMGP] function result.
    /// </summary>
    public class MGPInfo
    {
        /// <summary>
        /// The MGP ID.
        /// </summary>
        [JsonProperty("mgp_id")]
        public long MgpId { get; private set; }

        /// <summary>
        /// The MGP template ID.
        /// </summary>
        [JsonProperty("mgp_template_id")]
        public long MgpTemplateId { get; private set; }

        /// <summary>
        /// The MGP template price.
        /// </summary>
        [JsonProperty("mgp_template_price")]
        public long MgpTemplatePrice { get; private set; }

        /// <summary>
        /// The MGP template currency.
        /// </summary>
        [JsonProperty("mgp_template_currency")]
        public string MgpTemplateCurrency { get; private set; }

        /// <summary>
        /// The MGP activation date.
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("mgp_activated")]
        public DateTime MgpActivated { get; private set; }

        /// <summary>
        /// The MGP deactivation date.
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("mgp_deactivated")]
        public DateTime? MgpDeactivated { get; private set; }

    }
}
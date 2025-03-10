using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetMGPTemplateList] function result.
    /// </summary>
    public class MGPTemplateInfo
    {
        /// <summary>
        /// The MGP template ID
        /// </summary>
        [JsonProperty("mgp_template_id")]
        public long MgpTemplateId { get; private set; }

        /// <summary>
        /// The MGP template name
        /// </summary>
        [JsonProperty("mgp_template_name")]
        public string MgpTemplateName { get; private set; }

        /// <summary>
        /// The MGP template price
        /// </summary>
        [JsonProperty("mgp_template_price")]
        public long MgpTemplatePrice { get; private set; }

        /// <summary>
        /// The MGP template currency
        /// </summary>
        [JsonProperty("mgp_template_currency")]
        public string MgpTemplateCurrency { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [Dialogflow](/docs/references/httpapi/dialogflowcredentials) key's content.
    /// </summary>
    public class DialogflowKey
    {
        /// <summary>
        /// The project ID from Json Web Key
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectId { get; private set; }

    }
}
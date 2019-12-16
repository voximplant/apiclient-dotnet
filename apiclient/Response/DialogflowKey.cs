using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The
    /// [Dialogflow](https://voximplant.com/docs/references/httpapi/managing_dialogflow_credentials)
    /// key's content
    /// </summary>
    public class DialogflowKey
    {
        /// <summary>
        /// The project ID from Json Web Key.
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectId { get; private set; }

        /// <summary>
        /// The content of json file encoded with BASE64
        /// </summary>
        [JsonProperty("json_file")]
        public string JsonFile { get; private set; }

    }
}
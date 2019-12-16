using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class BindDialogflowKeysRequest : BaseRequest
    {
        /// <summary>
        /// The Dialogflow key's ID 
        /// </summary>
        [JsonProperty("dialogflow_key_id")]
        public long? DialogflowKeyId { get; set; }

        /// <summary>
        /// The application ID list separated by the ';' symbol or the 'all'
        /// value.
        /// </summary>
        [JsonProperty("application_id")]
        public Argument<long> ApplicationId { get; set; }

        /// <summary>
        /// Set to false to unbind. Default value is true.
        /// </summary>
        [JsonProperty("bind")]
        public bool? Bind { get; set; }

    }
}
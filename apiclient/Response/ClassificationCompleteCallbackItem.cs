using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details.
    /// </summary>
    public class ClassificationCompleteCallbackItem
    {
        /// <summary>
        /// The record ID.
        /// </summary>
        [JsonProperty("record_id")]
        public long RecordId { get; private set; }

        /// <summary>
        /// Array with the classification results.
        /// </summary>
        [JsonProperty("classification_info")]
        public ClassificationUnit[] ClassificationInfo { get; private set; }

        /// <summary>
        /// The cost of classification.
        /// </summary>
        [JsonProperty("classification_cost")]
        public decimal ClassificationCost { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Individual record in the  [ACDOperatorStatusAggregationGroupType] group.
    /// </summary>
    public class ACDOperatorStatusStatisticsType
    {
        /// <summary>
        /// If aggregation is enabled, contains user ID for the results
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; private set; }

        /// <summary>
        /// If aggregation is enabled, contains UTC date for the results in 24-h 'YYYY-MM-DD' format
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("date")]
        public DateTime? Date { get; private set; }

        /// <summary>
        /// If aggregation is enabled, contains the 60-minute interval number from 1 to 24
        /// </summary>
        [JsonProperty("hour")]
        public long? Hour { get; private set; }

        /// <summary>
        /// The user statistics
        /// </summary>
        [JsonProperty("acd_status")]
        public ACDOperatorStatusStatisticsDetail[] AcdStatus { get; private set; }

    }
}
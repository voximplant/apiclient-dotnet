using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Individual record in the [ACDOperatorAggregationGroupType] group.
    /// </summary>
    public class ACDOperatorStatisticsType
    {
        /// <summary>
        /// If aggregation was enabled, contains user ID for the results
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; private set; }

        /// <summary>
        /// If aggregation was enabled, contains UTC date for the results in 24-h 'YYYY-MM-DD' format
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("date")]
        public DateTime? Date { get; private set; }

        /// <summary>
        /// If aggregation was enabled, contains the 60-minute interval number from 1 to 24
        /// </summary>
        [JsonProperty("hour")]
        public long? Hour { get; private set; }

        /// <summary>
        /// Delay between a call started to ring and operator answered it. Name is 'SpeedOfAnswer' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("SA")]
        public ACDStatisticsItemType SA { get; private set; }

        /// <summary>
        /// Time between operator answering and ending a call. Name is 'TalkTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("TT")]
        public ACDStatisticsItemType TT { get; private set; }

        /// <summary>
        /// Time between operator ended a call and changed status to a one different from the 'AFTER_SERVICE'. This time is tracked only if operator changed status to 'AFTER_SERVICE' after the call. Name is 'AfterCallWork' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("ACW")]
        public ACDStatisticsItemType ACW { get; private set; }

        /// <summary>
        /// Sum of 'TalkTime' and 'AfterCallWork'. Name is 'HandlingTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("HT")]
        public ACDStatisticsItemType HT { get; private set; }

        /// <summary>
        /// Number of answered calls. Name is 'AnsweredCalls' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("AC")]
        public long? AC { get; private set; }

        /// <summary>
        /// Number of unanswered calls. Name is 'UnansweredCalls' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("UAC")]
        public long? UAC { get; private set; }

        /// <summary>
        /// Sum of delays between calls started to ring and operator answered them, in seconds. Name is 'TotalDialingTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("TDT")]
        public long? TDT { get; private set; }

        /// <summary>
        /// Sum of 'HandlingTime', in seconds. Name is 'TotalHandlingTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("THT")]
        public long? THT { get; private set; }

        /// <summary>
        /// Sum of 'TalkTime', in seconds. Name is 'TotalTalkTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("TTT")]
        public long? TTT { get; private set; }

        /// <summary>
        /// Sum of 'AfterCallWork', in seconds. Name is 'TotalAfterCallWork' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("TACW")]
        public long? TACW { get; private set; }

    }
}
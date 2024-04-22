using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Individual record in the [ACDOperatorAggregationGroupType] group.
    /// </summary>
    public class ACDQueueStatisticsType
    {
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
        /// Delay between user called and operator answered the call (or call is terminated). Name is 'WaitingTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("WT")]
        public ACDStatisticsItemType WT { get; private set; }

        /// <summary>
        /// Delay between a call started to ring and operator answered it. Name is 'SpeedOfAnswer' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("SA")]
        public ACDStatisticsItemType SA { get; private set; }

        /// <summary>
        /// Time between user called Voximplant cloud and time they disconnect not reaching the operator. Name is 'AbandonmentTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("AT")]
        public ACDStatisticsItemType AT { get; private set; }

        /// <summary>
        /// Sum of 'TalkTime' and 'AfterCallWork'. Name is 'HandlingTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("HT")]
        public ACDStatisticsItemType HT { get; private set; }

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
        /// How many users are in the queue. Name is 'QueueLength' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("QL")]
        public ACDStatisticsItemType QL { get; private set; }

        /// <summary>
        /// Total number of calls. Name is 'TotalCalls' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("TC")]
        public long? TC { get; private set; }

        /// <summary>
        /// Number of answered calls. Name is 'AnsweredCalls' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("AC")]
        public ACDStatisticsCalls[] AC { get; private set; }

        /// <summary>
        /// Number of unanswered calls. Name is 'UnansweredCalls' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("UAC")]
        public ACDStatisticsCalls[] UAC { get; private set; }

        /// <summary>
        /// Number of calls rejected by the ACD. Call is rejected if all operators are offline or banned, or queue length is exceeded, or predicted answer time exceeds maximum specified for the query. Name is 'RejectedCalls' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("RC")]
        public ACDStatisticsCalls[] RC { get; private set; }

        /// <summary>
        /// List of service levels. Name is 'ServiceLevel' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("SL")]
        public ACDQueueStatisticsServiceLevelType[] SL { get; private set; }

        /// <summary>
        /// Sum of 'WaitingTime', in seconds. Name is 'TotalWaitingTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("TWT")]
        public long? TWT { get; private set; }

        /// <summary>
        /// Sum of 'SpeedOfAnswer', in seconds. Name is 'TotalSubmissionTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("TST")]
        public long? TST { get; private set; }

        /// <summary>
        /// Sum for all times between user called Voximplant cloud and time they disconnect not reaching the operator, in seconds. Name is 'TotalAbandonmentTime' if 'abbreviation' is set to 'false'
        /// </summary>
        [JsonProperty("TAT")]
        public long? TAT { get; private set; }

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
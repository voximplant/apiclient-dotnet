using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetACDQueueStatisticsRequest : BaseRequest
    {
        /// <summary>
        /// Date and time of statistics interval begin. Time zone is UTC, format
        /// is 24-h 'YYYY-MM-DD HH:mm:ss'
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("from_date")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// Date and time of statistics interval begin. Time zone is UTC, format
        /// is 24-h 'YYYY-MM-DD HH:mm:ss'
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("to_date")]
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// If set to <b>true</b>, key names in returned JSON will be abbreviated
        /// to reduce response byte size. The abbreviations are: 'WT' for
        /// 'WaitingTime', 'SA' for 'SpeedOfAnswer', 'AT' is for
        /// 'AbandonmentTime', 'HT' is for 'HandlingTime', 'TT' is for
        /// 'TalkTime', 'ACW' is for 'AfterCallWork', 'QL' is for 'QueueLength',
        /// 'TC' is for 'TotalCalls', 'AC' is for 'AnsweredCalls', 'UAC' is for
        /// 'UnansweredCalls', 'RC' is for 'RejectedCalls', 'SL' is for
        /// 'ServiceLevel', 'TWT' is for 'TotalWaitingTime', 'TST' is for
        /// 'TotalSubmissionTime', 'TAT' is for 'TotalAbandonmentTime', 'THT' is
        /// for 'TotalHandlingTime', 'TTT' is for 'TotalTalkTime', 'TACW' is for
        /// 'TotalAfterCallWork'
        /// </summary>
        [JsonProperty("abbreviation")]
        public bool? Abbreviation { get; set; }

        /// <summary>
        /// The ACD queue ID list separated by the ';' symbol or the 'all' value.
        /// </summary>
        [JsonProperty("acd_queue_id")]
        public Argument<long> AcdQueueId { get; set; }

        /// <summary>
        /// List of item names abbreviations separated by the ';' symbol.
        /// Returned JSON will include keys only for the selected items. Special
        /// 'all' value defines all possible items, see [ACDQueueStatisticsType]
        /// for a complete list. See 'abbreviation' description for complete
        /// abbreviation list
        /// </summary>
        [JsonProperty("report")]
        public Argument<string> Report { get; set; }

        /// <summary>
        /// Specifies how records are grouped by date and time. If set to 'day',
        /// the criteria is a day number. If set to 'hour_of_day', the criteria
        /// is a 60-minute interval within a day. If set to 'hour', the criteria
        /// is both day number and 60-minute interval within that day. If set to
        /// 'none', records are not grouped by date and time
        /// </summary>
        [JsonProperty("aggregation")]
        public string Aggregation { get; set; }

    }
}
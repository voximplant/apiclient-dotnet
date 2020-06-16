using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetACDOperatorStatusStatisticsRequest : BaseRequest
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
        /// is 24-h 'YYYY-MM-DD HH:mm:ss'.
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("to_date")]
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// The ACD status list separated by the ';' symbol. The following values
        /// are possible: OFFLINE, ONLINE, READY, BANNED, IN_SERVICE,
        /// AFTER_SERVICE, TIMEOUT, DND.
        /// </summary>
        [JsonProperty("acd_status")]
        public Argument<string> AcdStatus { get; set; }

        /// <summary>
        /// The user ID list separated by the ';' symbol or the 'all' value. 
        /// </summary>
        [JsonProperty("user_id")]
        public Argument<string> UserId { get; set; }

        /// <summary>
        /// Specifies how records are grouped by date and time. If set to 'day',
        /// the criteria is a day number. If set to 'hour_of_day', the criteria
        /// is a 60-minute interval within a day. If set to 'hour', the criteria
        /// is both day number and 60-minute interval within that day. If set to
        /// 'none', records are not grouped by date and time.
        /// </summary>
        [JsonProperty("aggregation")]
        public string Aggregation { get; set; }

        /// <summary>
        /// If set to 'user', first-level array in the resulting JSON will group
        /// records by the user ID, and second-level array will group them by
        /// date according to the 'aggregation' parameter. If set to
        /// 'aggregation', first-level array in the resulting JSON will group
        /// records according to the 'aggregation' parameter, and second-level
        /// array will group them by the user ID.
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

    }
}
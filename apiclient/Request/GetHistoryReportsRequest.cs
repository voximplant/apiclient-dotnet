using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetHistoryReportsRequest : BaseRequest
    {
        /// <summary>
        /// The history report ID to filter
        /// </summary>
        [JsonProperty("history_report_id")]
        public long? HistoryReportId { get; set; }

        /// <summary>
        /// The history report type list separated by the ';' symbol or the 'all'
        /// value. The following values are possible: calls, transactions, audit,
        /// call_list.
        /// </summary>
        [JsonProperty("history_type")]
        public Argument<string> HistoryType { get; set; }

        /// <summary>
        /// The UTC creation from date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("created_from")]
        public DateTime? CreatedFrom { get; set; }

        /// <summary>
        /// The UTC creation to date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("created_to")]
        public DateTime? CreatedTo { get; set; }

        /// <summary>
        /// Is report completed?
        /// </summary>
        [JsonProperty("is_completed")]
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// Set true to get records in the descent order.
        /// </summary>
        [JsonProperty("desc_order")]
        public bool? DescOrder { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// The application ID to filter. Can be a list separated by the ';'
        /// symbol or the 'all' value.
        /// </summary>
        [JsonProperty("application_id")]
        public Argument<long> ApplicationId { get; set; }

    }
}
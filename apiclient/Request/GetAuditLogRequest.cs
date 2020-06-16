using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetAuditLogRequest : BaseRequest
    {
        /// <summary>
        /// The UTC 'from' date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("from_date")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// The UTC 'to' date filter in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("to_date")]
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// The selected timezone or the 'auto' value (will be used the account
        /// location).
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// The audit history ID list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("audit_log_id")]
        public Argument<long> AuditLogId { get; set; }

        /// <summary>
        /// The admin user ID to filter.
        /// </summary>
        [JsonProperty("filtered_admin_user_id")]
        public string FilteredAdminUserId { get; set; }

        /// <summary>
        /// The IP list separated by the ';' symbol to filter.
        /// </summary>
        [JsonProperty("filtered_ip")]
        public Argument<string> FilteredIp { get; set; }

        /// <summary>
        /// The function list separated by the ';' symbol to filter.
        /// </summary>
        [JsonProperty("filtered_cmd")]
        public Argument<string> FilteredCmd { get; set; }

        /// <summary>
        /// A relation ID to filter (for example: a phone_number value, a user_id
        /// value, an application_id value).
        /// </summary>
        [JsonProperty("advanced_filters")]
        public string AdvancedFilters { get; set; }

        /// <summary>
        /// Set false to get a CSV file without the column names if the output=csv
        /// </summary>
        [JsonProperty("with_header")]
        public bool? WithHeader { get; set; }

        /// <summary>
        /// Set true to get records in the descent order.
        /// </summary>
        [JsonProperty("desc_order")]
        public bool? DescOrder { get; set; }

        /// <summary>
        /// Set false to omit the 'total_count' and increase performance.
        /// </summary>
        [JsonProperty("with_total_count")]
        public bool? WithTotalCount { get; set; }

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
        /// The output format. The following values available: json, csv.
        /// </summary>
        [JsonProperty("output")]
        public string Output { get; set; }

        /// <summary>
        /// Set true to get records in the asynchronous mode (for csv output
        /// only). If it's true, the request could be available via
        /// [GetHistoryReports] and [DownloadHistoryReport] methods.
        /// </summary>
        [JsonProperty("is_async")]
        public bool? IsAsync { get; set; }

    }
}
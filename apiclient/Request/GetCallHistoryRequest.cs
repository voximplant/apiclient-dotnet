using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetCallHistoryRequest : BaseRequest
    {
        /// <summary>
        /// The from date in the selected timezone in 24-h format: YYYY-MM-DD
        /// HH:mm:ss
        /// </summary>
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        [JsonProperty("from_date")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// The to date in the selected timezone in 24-h format: YYYY-MM-DD
        /// HH:mm:ss
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
        /// The call session history ID list separated by the ';' symbol. The
        /// sessions IDs can be accessed in JS scenario via the <b>sessionID</b>
        /// property of the <a
        /// href='//voximplant.com/docs/references/voxengine/appevents#started'>AppEvents.Started</a>
        /// event
        /// </summary>
        [JsonProperty("call_session_history_id")]
        public Argument<long> CallSessionHistoryId { get; set; }

        /// <summary>
        /// The application ID.
        /// </summary>
        [JsonProperty("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// The application name, can be used instead of <b>application_id</b>.
        /// </summary>
        [JsonProperty("application_name")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The user ID list separated by the ';' symbol. If it's specified, the
        /// output will contain the calls from the listed users only.
        /// </summary>
        [JsonProperty("user_id")]
        public Argument<long> UserId { get; set; }

        /// <summary>
        /// The rule name to filter.
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// The remote number list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("remote_number")]
        public Argument<string> RemoteNumber { get; set; }

        /// <summary>
        /// The local number list separated by the ';' symbol.
        /// </summary>
        [JsonProperty("local_number")]
        public Argument<string> LocalNumber { get; set; }

        /// <summary>
        /// The custom_data to filter sessions.
        /// </summary>
        [JsonProperty("call_session_history_custom_data")]
        public string CallSessionHistoryCustomData { get; set; }

        /// <summary>
        /// Set true to get the bound calls.
        /// </summary>
        [JsonProperty("with_calls")]
        public bool? WithCalls { get; set; }

        /// <summary>
        /// Set true to get the bound records.
        /// </summary>
        [JsonProperty("with_records")]
        public bool? WithRecords { get; set; }

        /// <summary>
        /// Set true to get other resources usage (see [ResourceUsageType]).
        /// </summary>
        [JsonProperty("with_other_resources")]
        public bool? WithOtherResources { get; set; }

        /// <summary>
        /// The child account ID list separated by the ';' symbol or the 'all'
        /// value.
        /// </summary>
        [JsonProperty("child_account_id")]
        public Argument<long> ChildAccountId { get; set; }

        /// <summary>
        /// Set true to get the children account calls only.
        /// </summary>
        [JsonProperty("children_calls_only")]
        public bool? ChildrenCallsOnly { get; set; }

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
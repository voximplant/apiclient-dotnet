using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The history report info.
    /// </summary>
    public class HistoryReportType
    {
        /// <summary>
        /// The call history report ID
        /// </summary>
        [JsonProperty("history_report_id")]
        public long HistoryReportId { get; private set; }

        /// <summary>
        /// The history report type. The following values are possible: calls, transactions, audit, call_list
        /// </summary>
        [JsonProperty("history_type")]
        public string HistoryType { get; private set; }

        /// <summary>
        /// The creation time in the UTC timezone in 24-h format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; private set; }

        /// <summary>
        /// The report format type. The following values are possible: csv
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; private set; }

        /// <summary>
        /// The UTC completion time in 24-h format: YYYY-MM-DD HH:mm:ss. The report is completed if the field exists
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("completed")]
        public DateTime? Completed { get; private set; }

        /// <summary>
        /// The report file name
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName { get; private set; }

        /// <summary>
        /// The report file size
        /// </summary>
        [JsonProperty("file_size")]
        public decimal? FileSize { get; private set; }

        /// <summary>
        /// The gzipped report size to download
        /// </summary>
        [JsonProperty("download_size")]
        public decimal? DownloadSize { get; private set; }

        /// <summary>
        /// The download attempt count
        /// </summary>
        [JsonProperty("download_count")]
        public long? DownloadCount { get; private set; }

        /// <summary>
        /// The last download UTC time in 24-h format: YYYY-MM-DD HH:mm:ss. The report is completed if the field exists
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("last_downloaded")]
        public DateTime? LastDownloaded { get; private set; }

        /// <summary>
        /// Store the report until the UTC time in 24-h format: YYYY-MM-DD HH:mm:ss. The report is completed if the field exists
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("store_until")]
        public DateTime? StoreUntil { get; private set; }

        /// <summary>
        /// The report error
        /// </summary>
        [JsonProperty("error")]
        public API_Error Error { get; private set; }

        /// <summary>
        /// The report order filters (the saved [GetCallHistory], [GetTransactionHistory] parameters)
        /// </summary>
        [JsonProperty("filters")]
        public Object Filters { get; private set; }

        /// <summary>
        /// The calculated report data (the specific report data, see [CalculatedCallHistoryDataType], [CalculatedTransactionHistoryDataType])
        /// </summary>
        [JsonProperty("calculated_data")]
        public Object CalculatedData { get; private set; }

    }
}
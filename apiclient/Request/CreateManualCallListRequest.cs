using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class CreateManualCallListRequest : BaseRequest
    {
        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; set; }

        /// <summary>
        /// Call list priority. The value is in the range of [0 ... 2^31] where
        /// zero is the highest priority.
        /// </summary>
        [JsonProperty("priority")]
        public long? Priority { get; set; }

        /// <summary>
        /// Number simultaneously processed tasks.
        /// </summary>
        [JsonProperty("max_simultaneous")]
        public long? MaxSimultaneous { get; set; }

        /// <summary>
        /// Number of attempts. Should be equal or greater than <b>1</b>
        /// </summary>
        [JsonProperty("num_attempts")]
        public long? NumAttempts { get; set; }

        /// <summary>
        /// File name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Send as "body" part of the HTTP request or as multiform. The sending
        /// "file_content" via URL is at its own risk because the network devices
        /// tend to drop HTTP requests with large headers.
        /// </summary>
        [JsonProperty("file_content")]
        public string FileContent { get; set; }

        /// <summary>
        /// Interval between call attempts in seconds. The default is 0.
        /// </summary>
        [JsonProperty("interval_seconds")]
        public long? IntervalSeconds { get; set; }

        /// <summary>
        /// Encoding file. The default is UTF-8.
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// Separator values. The default is ';'
        /// </summary>
        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }

        /// <summary>
        /// Escape character. Used for parsing csv
        /// </summary>
        [JsonProperty("escape")]
        public string Escape { get; set; }

        /// <summary>
        /// Specifies the IP from the geolocation of call list subscribers. It
        /// allows selecting the nearest server for serving subscribers.
        /// </summary>
        [JsonProperty("reference_ip")]
        public string ReferenceIp { get; set; }

    }
}
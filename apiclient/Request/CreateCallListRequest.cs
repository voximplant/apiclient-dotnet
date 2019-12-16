using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class CreateCallListRequest : BaseRequest
    {
        /// <summary>
        /// The rule ID. It's specified in the <a
        /// href='//manage.voximplant.com/#applications'>Applications</a> section
        /// of the Control Panel
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
        /// Number of attempts. Minimum is <b>1</b>, maximum is <b>5</b>.
        /// </summary>
        [JsonProperty("num_attempts")]
        public long? NumAttempts { get; set; }

        /// <summary>
        /// File name, up to 255 characters and can't contain the '/' and '\'
        /// symbols.
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
        /// Queue Id. For processing call list with PDS (predictive dialer) the
        /// ID of the queue must be specified.
        /// </summary>
        [JsonProperty("queue_id")]
        public long? QueueId { get; set; }

        /// <summary>
        /// Average waiting time in the queue(seconds). Default is 1
        /// </summary>
        [JsonProperty("avg_waiting_sec")]
        public long? AvgWaitingSec { get; set; }

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
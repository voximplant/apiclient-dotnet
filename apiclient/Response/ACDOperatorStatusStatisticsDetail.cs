using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Individual record in [ACDOperatorStatusStatisticsType].
    /// </summary>
    public class ACDOperatorStatusStatisticsDetail
    {
        /// <summary>
        /// The OFFLINE status statistics
        /// </summary>
        [JsonProperty("OFFLINE")]
        public ACDStatisticsItemType OFFLINE { get; private set; }

        /// <summary>
        /// The ONLINE status statistics
        /// </summary>
        [JsonProperty("ONLINE")]
        public ACDStatisticsItemType ONLINE { get; private set; }

        /// <summary>
        /// The READY status statistics
        /// </summary>
        [JsonProperty("READY")]
        public ACDStatisticsItemType READY { get; private set; }

        /// <summary>
        /// The BANNED status statistics
        /// </summary>
        [JsonProperty("BANNED")]
        public ACDStatisticsItemType BANNED { get; private set; }

        /// <summary>
        /// The IN_SERVICE status statistics
        /// </summary>
        [JsonProperty("IN_SERVICE")]
        public ACDStatisticsItemType INSERVICE { get; private set; }

        /// <summary>
        /// The AFTER_SERVICE status statistics
        /// </summary>
        [JsonProperty("AFTER_SERVICE")]
        public ACDStatisticsItemType AFTERSERVICE { get; private set; }

        /// <summary>
        /// The TIMEOUT status statistics
        /// </summary>
        [JsonProperty("TIMEOUT")]
        public ACDStatisticsItemType TIMEOUT { get; private set; }

        /// <summary>
        /// The DND status statistics
        /// </summary>
        [JsonProperty("DND")]
        public ACDStatisticsItemType DND { get; private set; }

    }
}
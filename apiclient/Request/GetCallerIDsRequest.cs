using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetCallerIDsRequest : BaseRequest
    {
        /// <summary>
        /// The id of the callerID object to filter.
        /// </summary>
        [JsonProperty("callerid_id")]
        public long? CalleridId { get; set; }

        /// <summary>
        /// The phone number to filter.
        /// </summary>
        [JsonProperty("callerid_number")]
        public string CalleridNumber { get; set; }

        /// <summary>
        /// The active flag to filter.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The following values are available: 'caller_number' (ascent order),
        /// 'verified_until' (ascent order).
        /// </summary>
        [JsonProperty("order_by")]
        public string OrderBy { get; set; }

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

    }
}
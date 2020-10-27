using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetPhoneNumbersResponse : BaseResponse
    {

        [JsonProperty("result")]
        public AttachedPhoneInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found phone count.
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The returned phone count.
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
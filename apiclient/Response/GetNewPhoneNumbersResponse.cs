using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetNewPhoneNumbersResponse : BaseResponse
    {

        [JsonProperty("result")]
        public NewPhoneInfoType[] Result { get; private set; }

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
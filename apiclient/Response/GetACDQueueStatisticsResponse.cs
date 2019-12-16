using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetACDQueueStatisticsResponse : BaseResponse
    {
        /// <summary>
        /// List of records grouped grouped by date according to the
        /// 'aggregation' method call argument
        /// </summary>
        [JsonProperty("result")]
        public IReadOnlyList<ACDQueueStatisticsType> Result { get; private set; }

    }
}
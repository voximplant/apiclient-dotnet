using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetACDOperatorStatisticsResponse : BaseResponse
    {
        /// <summary>
        /// List of groups, grouped by user ID or date according to the 'group' method call argument
        /// </summary>
        [JsonProperty("result")]
        public ACDOperatorAggregationGroupType[] Result { get; private set; }

    }
}
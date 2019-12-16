using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetRegionsResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<RegulationRegionRecord> Result { get; private set; }


        [JsonProperty("count")]
        public long? Count { get; private set; }

    }
}
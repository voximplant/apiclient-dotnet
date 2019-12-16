using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetCountriesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public IReadOnlyList<RegulationCountry> Result { get; private set; }


        [JsonProperty("count")]
        public long? Count { get; private set; }

    }
}
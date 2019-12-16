using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetRegulationsAddressResponse : BaseResponse
    {
        /// <summary>
        /// The RegulationAddress records.
        /// </summary>
        [JsonProperty("result")]
        public IReadOnlyList<RegulationAddress> Result { get; private set; }

        /// <summary>
        /// The returned regulation address count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; private set; }

    }
}
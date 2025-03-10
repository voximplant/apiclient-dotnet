using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetTransactionHistoryResponse : BaseResponse
    {

        [JsonProperty("result")]
        public TransactionInfoType[] Result { get; private set; }

        /// <summary>
        /// The total found transaction count
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; private set; }

        /// <summary>
        /// The used timezone. 'Etc/GMT' for example
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; private set; }

        /// <summary>
        /// The returned transaction count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; private set; }

    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The contract info (the ContractorInfoType field).
    /// </summary>
    public class ContractInfoType
    {
        /// <summary>
        /// The agreement number
        /// </summary>
        [JsonProperty("agreement_number")]
        public string AgreementNumber { get; private set; }

        /// <summary>
        /// The agreement date in format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("agreement_date")]
        public DateTime? AgreementDate { get; private set; }

    }
}
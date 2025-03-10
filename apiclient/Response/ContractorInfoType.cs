using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetContractorInfo] function result.
    /// </summary>
    public class ContractorInfoType
    {
        /// <summary>
        /// Russian-specific ID for tax purposes
        /// </summary>
        [JsonProperty("inn")]
        public string Inn { get; private set; }

        /// <summary>
        /// Additional Russian-specific ID for tax purposes for businesses; there is no KPP for individual entrepreneurs
        /// </summary>
        [JsonProperty("kpp")]
        public string Kpp { get; private set; }

        /// <summary>
        /// The full company name
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; private set; }

        /// <summary>
        /// The full company address with a postcode
        /// </summary>
        [JsonProperty("company_address")]
        public string CompanyAddress { get; private set; }

        /// <summary>
        /// The company phone
        /// </summary>
        [JsonProperty("company_phone")]
        public string CompanyPhone { get; private set; }

        /// <summary>
        /// The correspondence address
        /// </summary>
        [JsonProperty("correspondence_address")]
        public string CorrespondenceAddress { get; private set; }

        /// <summary>
        /// The correspondence email
        /// </summary>
        [JsonProperty("correspondence_email")]
        public string CorrespondenceEmail { get; private set; }

        /// <summary>
        /// The correspondence to
        /// </summary>
        [JsonProperty("correspondence_to")]
        public string CorrespondenceTo { get; private set; }

        /// <summary>
        /// The contract info
        /// </summary>
        [JsonProperty("contract")]
        public ContractInfoType Contract { get; private set; }

    }
}
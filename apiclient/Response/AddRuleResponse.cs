using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddRuleResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long? Result { get; private set; }

        /// <summary>
        /// The new rule ID.
        /// </summary>
        [JsonProperty("rule_id")]
        public long? RuleId { get; private set; }

    }
}
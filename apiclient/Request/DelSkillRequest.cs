using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class DelSkillRequest : BaseRequest
    {
        /// <summary>
        /// The skill ID.
        /// </summary>
        [JsonProperty("skill_id")]
        public long? SkillId { get; set; }

        /// <summary>
        /// The skill name that can be used instead of <b>skill_id</b>.
        /// </summary>
        [JsonProperty("skill_name")]
        public string SkillName { get; set; }

    }
}
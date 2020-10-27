using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The cloned ACD skill info.
    /// </summary>
    public class ClonedACDSkillType
    {
        /// <summary>
        /// The ACD skill ID.
        /// </summary>
        [JsonProperty("skill_id")]
        public long SkillId { get; private set; }

        /// <summary>
        /// The ACD skill name.
        /// </summary>
        [JsonProperty("skill_name")]
        public string SkillName { get; private set; }

    }
}
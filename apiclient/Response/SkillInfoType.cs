using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetSkills] function result.
    /// </summary>
    public class SkillInfoType
    {
        /// <summary>
        /// The skill ID.
        /// </summary>
        [JsonProperty("skill_id")]
        public long? SkillId { get; private set; }

        /// <summary>
        /// The skill name.
        /// </summary>
        [JsonProperty("skill_name")]
        public string SkillName { get; private set; }

    }
}
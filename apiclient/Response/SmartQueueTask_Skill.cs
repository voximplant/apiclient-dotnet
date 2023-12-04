using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Task skill info.
    /// </summary>
    public class SmartQueueTask_Skill
    {
        /// <summary>
        /// The skill name
        /// </summary>
        [JsonProperty("sq_skill_name")]
        public string SqSkillName { get; private set; }

        /// <summary>
        /// The skill level
        /// </summary>
        [JsonProperty("sq_skill_level")]
        public long SqSkillLevel { get; private set; }

    }
}
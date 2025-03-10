using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// Agent skill info.
    /// </summary>
    public class SmartQueueAgent_Skill
    {
        /// <summary>
        /// The agent skill ID
        /// </summary>
        [JsonProperty("sq_skill_id")]
        public long SqSkillId { get; private set; }

        /// <summary>
        /// The agent skill name
        /// </summary>
        [JsonProperty("sq_skill_name")]
        public string SqSkillName { get; private set; }

        /// <summary>
        /// The agent skill level
        /// </summary>
        [JsonProperty("sq_skill_level")]
        public long SqSkillLevel { get; private set; }

    }
}
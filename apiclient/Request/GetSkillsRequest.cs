using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class GetSkillsRequest : BaseRequest
    {
        /// <summary>
        /// The skill ID to filter.
        /// </summary>
        [JsonProperty("skill_id")]
        public long? SkillId { get; set; }

        /// <summary>
        /// The skill name part to filter.
        /// </summary>
        [JsonProperty("skill_name")]
        public string SkillName { get; set; }

        /// <summary>
        /// The max returning record count.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The first <b>N</b> records will be skipped in the output.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

    }
}
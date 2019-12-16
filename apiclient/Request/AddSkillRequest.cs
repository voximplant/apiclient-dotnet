using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class AddSkillRequest : BaseRequest
    {
        /// <summary>
        /// The ACD operator skill name. The length must be less than 512.
        /// </summary>
        [JsonProperty("skill_name")]
        public string SkillName { get; set; }

    }
}
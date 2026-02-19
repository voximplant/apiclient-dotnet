using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class AddSkillResponse : BaseResponse
    {
        /// <summary>
        /// Returns 1 if the request has been completed successfully
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The skill ID
        /// </summary>
        [JsonProperty("skill_id")]
        public long SkillId { get; private set; }

    }
}
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class StartScenariosResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long Result { get; private set; }

        /// <summary>
        /// The URL to control a created media session. You can use it for arbitrary tasks such as stopping scenario or passing additional data to it. Making HTTP request on this URL results in the [AppEvents.HttpRequest](/docs/references/voxengine/appevents#httprequest) VoxEngine event being triggered for scenario, with HTTP request data passed to it
        /// </summary>
        [JsonProperty("media_session_access_url")]
        public string MediaSessionAccessUrl { get; private set; }

        /// <summary>
        /// The URL to control a created media session. You can use it for arbitrary tasks such as stopping scenario or passing additional data to it. Making HTTPS request on this URL results in the [AppEvents.HttpRequest](/docs/references/voxengine/appevents#httprequest) VoxEngine event being triggered for scenario, with HTTP request data passed to it
        /// </summary>
        [JsonProperty("media_session_access_secure_url")]
        public string MediaSessionAccessSecureUrl { get; private set; }

        /// <summary>
        /// The call session history ID. To search a call session result, paste the ID to the <a href='/docs/references/httpapi/history#getcallhistory'>GetCallHistory</a> method's <b>call_session_history_id</b> parameter
        /// </summary>
        [JsonProperty("call_session_history_id")]
        public long CallSessionHistoryId { get; private set; }

    }
}
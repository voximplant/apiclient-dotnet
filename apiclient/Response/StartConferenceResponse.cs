using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class StartConferenceResponse : BaseResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public long? Result { get; private set; }

        /// <summary>
        /// The URL to control a created media session. It can be used for
        /// arbitrary tasks such as stopping scenario or passing additional data
        /// to it. Making HTTP request on this URL will result in the
        /// [AppEvents.HttpRequest](https://voximplant.com/docs/references/voxengine/appevents#httprequest)
        /// VoxEngine event being triggered for a scenario, with an HTTP request
        /// data passed to it.
        /// </summary>
        [JsonProperty("media_session_access_url")]
        public string MediaSessionAccessUrl { get; private set; }

        /// <summary>
        /// The URL to control a created media session. It can be used for
        /// arbitrary tasks such as stopping scenario or passing additional data
        /// to it. Making HTTPS request on this URL will result in the
        /// [AppEvents.HttpRequest](https://voximplant.com/docs/references/voxengine/appevents#httprequest)
        /// VoxEngine event being triggered for a scenario, with an HTTP request
        /// data passed to it.
        /// </summary>
        [JsonProperty("media_session_access_secure_url")]
        public string MediaSessionAccessSecureUrl { get; private set; }

    }
}
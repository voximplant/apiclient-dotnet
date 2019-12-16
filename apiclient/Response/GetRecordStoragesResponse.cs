using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    public class GetRecordStoragesResponse : BaseResponse
    {

        [JsonProperty("result")]
        public RecordStorageInfoType Result { get; private set; }

    }
}
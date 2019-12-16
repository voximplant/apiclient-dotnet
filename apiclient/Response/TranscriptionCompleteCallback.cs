using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details. Received as part of the
    /// [AccountCallback] structure.
    /// </summary>
    public class TranscriptionCompleteCallback
    {
        /// <summary>
        /// The transcription info.
        /// </summary>
        [JsonProperty("transcription_complete")]
        public TranscriptionCompleteCallbackItem TranscriptionComplete { get; private set; }

    }
}
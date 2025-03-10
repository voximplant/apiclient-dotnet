using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The specific account callback details.
    /// </summary>
    public class TranscriptionCompleteCallbackItem
    {
        /// <summary>
        /// The record url
        /// </summary>
        [JsonProperty("record_url")]
        public string RecordUrl { get; private set; }

        /// <summary>
        /// Transcription URL. To open the URL, please add authorization parameters and <b>record_id</b> to it
        /// </summary>
        [JsonProperty("transcription_url")]
        public string TranscriptionUrl { get; private set; }

        /// <summary>
        /// The call session history ID
        /// </summary>
        [JsonProperty("call_session_history_id")]
        public long CallSessionHistoryId { get; private set; }

        /// <summary>
        /// The cost of transcription
        /// </summary>
        [JsonProperty("transcription_cost")]
        public decimal TranscriptionCost { get; private set; }

    }
}
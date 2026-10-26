using System;
using System.Net.Http;
using Newtonsoft.Json.Serialization;

namespace Voximplant.API
{
    public class ClientConfiguration
    {
        public bool UseHTTPS { get; set; }
        public ITraceWriter TraceWriter { get; set; }
        private string _apiHost;
        private string _keyFile;
        private long _accountId;

        public ClientConfiguration()
        {
            UseHTTPS = true;
        }

        /// <summary>
        /// Optional delegate that supplies the <see cref="HttpClient"/> for each request.
        /// When unset, requests reuse one process-wide client.
        /// The library does not dispose clients returned by this delegate.
        /// </summary>
        public Func<HttpClient> CreateHttpClient { get; set; }

        public string APIHost
        {
            get => string.IsNullOrEmpty(_apiHost) ? "api.voximplant.com" : _apiHost;
            set => _apiHost = value;
        }

        public string KeyFile
        {
            get => string.IsNullOrEmpty(_keyFile)
                ? Environment.GetEnvironmentVariable("VOXIMPLANT_CREDENTIALS")
                : _keyFile;
            set => _keyFile = value;
        }
        
        public long AccountId
        {
            get => _accountId;
            set => _accountId = value;
        }
    }
}
using System;
using Newtonsoft.Json.Serialization;

namespace Voximplant.API
{
    public class ClientConfiguration
    {
        public bool UseHTTPS { get; set; }
        public ITraceWriter TraceWriter { get; set; }
        private string _apiHost;
        private string _keyFile;

        public ClientConfiguration()
        {
            UseHTTPS = true;
        }

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
    }
}
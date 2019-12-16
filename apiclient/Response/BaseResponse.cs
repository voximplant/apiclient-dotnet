using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response
{
    public abstract class BaseResponse
    {
        [JsonProperty("error")]
        private API_Error _error = null;

        internal bool HasError()
        {
            return _error != null;
        }

        internal API_Error GetError()
        {
            return _error;
        }

        [JsonProperty("errors")]
        private List<API_Error> _errors = null;

        internal bool HasErrors()
        {
            return _errors != null;
        }

        internal IReadOnlyList<API_Error> GetErrors()
        {
            return _errors;
        }
    }
}
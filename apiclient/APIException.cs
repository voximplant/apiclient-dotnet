using System;

namespace Voximplant.API
{
    public class APIException : Exception
    {
        public readonly long Code;

        public APIException(string message, long? code) : base(message)
        {
            if (code != null) Code = (long) code;
        }
    }
}
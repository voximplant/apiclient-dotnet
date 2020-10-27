using System;

namespace Voximplant.API
{
    public class VoximplantException : Exception
    {
        public long? Code { get; }

        internal VoximplantException(string message, long? code = null) : base(message)
        {
            if (code.HasValue) {
                Code = code.Value;
            }
        }
    }
}
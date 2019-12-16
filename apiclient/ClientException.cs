using System;

namespace Voximplant.API
{
    public class ClientException : Exception
    {
        public ClientException(string message) : base(message)
        {
        }
    }
}
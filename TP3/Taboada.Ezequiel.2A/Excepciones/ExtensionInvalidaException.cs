using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    public class ExtensionInvalidaException : Exception
    {
        public ExtensionInvalidaException()
        {
        }

        public ExtensionInvalidaException(string message) : base(message)
        {
        }

        public ExtensionInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }
        
    }
}

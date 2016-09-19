using System;
using System.Runtime.Serialization;

namespace SlackConnector.Exceptions
{
    public class MissingChannelException : Exception
    {
        public MissingChannelException()
        { }

        public MissingChannelException(string message) : base(message)
        { }

        public MissingChannelException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
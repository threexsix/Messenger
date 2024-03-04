using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

public class ClientReadMessageException : Exception
{
    public ClientReadMessageException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public ClientReadMessageException(string message)
        : base(message)
    {
    }

    public ClientReadMessageException()
    {
    }
}
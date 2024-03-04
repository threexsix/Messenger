using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

public class PriorityValueException : Exception
{
    public PriorityValueException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public PriorityValueException(string message)
        : base(message)
    {
    }

    public PriorityValueException()
    {
    }
}
using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers;

public class MessageLogger : ILogger
{
    public void Log(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        string log = $"{DateTime.Now}: {message.Header} was logged with priority : {message.PriorityLevel}";
        Console.WriteLine(log);
    }
}
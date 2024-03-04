using Itmo.ObjectOrientedProgramming.Lab3.Loggers;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Moqs;

public class MoqLogger : ILogger
{
    public MoqLogger()
    {
        CallCounter = 0;
    }

    public int CallCounter { get; private set; }

    public void Log(IMessage message)
    {
        CallCounter++;
    }
}
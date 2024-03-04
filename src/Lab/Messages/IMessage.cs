using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public interface IMessage
{
    public string Header { get; }
    public string Body { get; }
    public PriorityLevel PriorityLevel { get; }
}
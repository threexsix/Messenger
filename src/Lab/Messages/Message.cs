using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class Message : IMessage
{
    public Message(string header, string body, PriorityLevel priorityLevel)
    {
        Header = header ?? throw new ArgumentNullException(nameof(header));
        Body = body ?? throw new ArgumentNullException(nameof(body));
        PriorityLevel = priorityLevel ?? throw new ArgumentNullException(nameof(priorityLevel));
    }

    public string Header { get; }
    public string Body { get; }
    public PriorityLevel PriorityLevel { get; }
}
using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class MessageDebuilder
{
    private string _header;
    private string _body;
    private PriorityLevel _priorityLevel;

    public MessageDebuilder(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        _header = message.Header;
        _body = message.Body;
        _priorityLevel = message.PriorityLevel;
    }

    public MessageDebuilder WithAnotherHeader(string priorityLevel)
    {
        _header = priorityLevel;
        return this;
    }

    public MessageDebuilder WithAnotherBody(string body)
    {
        _body = body;
        return this;
    }

    public MessageDebuilder WithAnotherPriorityLevel(PriorityLevel priorityLevel)
    {
        _priorityLevel = priorityLevel;
        return this;
    }

    public IMessage Build()
    {
        return new MessageBuilder().WithHeader(_header).WithBody(_body).WithPriorityLevel(_priorityLevel).Build();
    }
}
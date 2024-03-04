using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class MessageBuilder
{
    private string? _header;
    private string? _body;
    private PriorityLevel? _priorityLevel;

    public MessageBuilder WithHeader(string priorityLevel)
    {
        _header = priorityLevel;
        return this;
    }

    public MessageBuilder WithBody(string body)
    {
        _body = body;
        return this;
    }

    public MessageBuilder WithPriorityLevel(PriorityLevel priorityLevel)
    {
        _priorityLevel = priorityLevel;
        return this;
    }

    public IMessage Build()
    {
        if (_header is null || _body is null || _priorityLevel is null)
            throw new ArgumentNullException();

        return new Message(_header, _body, _priorityLevel);
    }
}
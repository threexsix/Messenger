using System;
using Itmo.ObjectOrientedProgramming.Lab3.Loggers;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AddresseeProxy : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly ILogger _logger;
    private readonly PriorityLevel _priority;

    public AddresseeProxy(IAddressee addressee, PriorityLevel priority, ILogger logger)
    {
        _addressee = addressee;
        _priority = priority;
        _logger = logger;
    }

    public void ReceiveMessage(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        if (message.PriorityLevel < _priority) return;

        _addressee.ReceiveMessage(message);
        _logger.Log(message);
    }
}
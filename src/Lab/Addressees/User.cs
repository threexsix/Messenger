using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class User : IAddressee
{
    private readonly List<IMessage> _readMessages;
    private readonly List<IMessage> _unreadMessages;

    public User()
    {
        _readMessages = new List<IMessage>();
        _unreadMessages = new List<IMessage>();
    }

    public IReadOnlyCollection<IMessage> ReadMessages => _readMessages;
    public IReadOnlyCollection<IMessage> UnreadMessages => _unreadMessages;

    public void ReceiveMessage(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        _unreadMessages.Add(message);
    }

    public void ReadMessage(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        if (_readMessages.Contains(message) || !_unreadMessages.Contains(message))
            throw new ClientReadMessageException("Message is already seen or wasn't sent to these addressee");

        _readMessages.Add(message);
        _unreadMessages.Remove(message);
    }
}
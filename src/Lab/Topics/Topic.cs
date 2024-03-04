using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topics;

public class Topic : ITopic
{
    public Topic(IAddressee addressee)
    {
        ArgumentNullException.ThrowIfNull(addressee);

        Addressee = addressee;
    }

    public IAddressee Addressee { get; }

    public void Receive(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        Pass(message);
    }

    public void Pass(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        Addressee.ReceiveMessage(message);
    }
}
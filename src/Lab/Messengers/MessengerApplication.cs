using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers;

public class MessengerApplication : IMessenger
{
    public void ReceiveMessage(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        ShowMessage(message);
    }

    public void ShowMessage(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        string output = message.Body + "Messenger";
        Console.WriteLine(output);
    }
}
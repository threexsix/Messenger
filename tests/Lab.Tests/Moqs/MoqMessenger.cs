using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Messengers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Moqs;

public class MoqMessenger : IMessenger
{
    public MoqMessenger()
    {
        ShownMessagesCounter = 0;
    }

    public int ShownMessagesCounter { get; private set; }

    public void ReceiveMessage(IMessage message)
    {
        ShowMessage(message);
    }

    public void ShowMessage(IMessage message)
    {
        ShownMessagesCounter++;
    }
}
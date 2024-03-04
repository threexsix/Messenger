using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topics;

public interface ITopic
{
    public IAddressee Addressee { get; }
    public void Receive(IMessage message);
    public void Pass(IMessage message);
}
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public interface IDisplay : IAddressee
{
    public void ShowMessage();
}
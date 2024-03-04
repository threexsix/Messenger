using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class Display : IDisplay
{
    private readonly DisplayDriver _displayDriver;

    public Display()
    {
        _displayDriver = new();
    }

    public DisplayDriver DisplayDriver => _displayDriver;
    public void ReceiveMessage(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        _displayDriver.ClearOutput();
        _displayDriver.ReceiveInput(message);
    }

    public void ShowMessage()
    {
        _displayDriver.ShowOutput();
    }
}
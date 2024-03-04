using System;
using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class DisplayDriver
{
    private string _output;
    private Color _color;

    public DisplayDriver()
    {
        _output = string.Empty;
        _color = Color.White;
    }

    public void SetColor(Color color)
    {
        _color = color;
    }

    public void ReceiveInput(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        _output = message.Body;
    }

    public void ClearOutput()
    {
        _output = string.Empty;
    }

    public void ShowOutput()
    {
        _output = Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(_output);
        Console.WriteLine(_output);
    }
}
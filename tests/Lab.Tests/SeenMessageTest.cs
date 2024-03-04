using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Topics;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class SeenMessageTest
{
    [Fact]
    public void SuccessMessageCheck()
    {
        // Assign
        Message message = new("From Cat", "meow meow, meow? meowmeow meow meow. Meow", new PriorityLevel(0));
        User addressee = new();
        Topic topic = new(addressee);

        // Act
        topic.Receive(message);
        addressee.ReadMessage(message);

        // Assert
        Assert.Contains(message, addressee.ReadMessages);
    }
}
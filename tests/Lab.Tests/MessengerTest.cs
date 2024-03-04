using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Tests.Moqs;
using Itmo.ObjectOrientedProgramming.Lab3.Topics;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MessengerTest
{
    [Fact]
    public void SuccessMessageReceive()
    {
        // Assign
        Message message1 = new("From Cat", "meow meow, meow? meowmeow meow meow. Meow", new PriorityLevel(0));
        Message message2 = new("From Good Boy", "woof woof? woof woof woof", new PriorityLevel(0));
        MoqMessenger moqMessenger = new();
        Topic topic = new(moqMessenger);

        // Act
        topic.Receive(message1);
        topic.Receive(message2);

        // Assert
        Assert.Equal(2, moqMessenger.ShownMessagesCounter);
    }
}
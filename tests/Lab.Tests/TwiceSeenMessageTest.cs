using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Topics;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TwiceSeenMessageTest
{
    [Fact]
    public void TwiceSeenMessageByClient()
    {
        // Assign
        Message message = new("From Cat", "meow meow, meow? meowmeow meow meow. Meow", new PriorityLevel(0));
        User addressee = new();
        Topic topic = new(addressee);

        // Act
        ClientReadMessageException ex = Assert.Throws<ClientReadMessageException>(() =>
        {
            topic.Receive(message);
            addressee.ReadMessage(message);
            addressee.ReadMessage(message);
        });

        // Assert
        Assert.Equal("Message is already seen or wasn't sent to these addressee", ex.Message);
    }
}
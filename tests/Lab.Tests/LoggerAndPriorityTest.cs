using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Tests.Moqs;
using Itmo.ObjectOrientedProgramming.Lab3.Topics;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;
public class LoggerAndPriorityTest
{
    [Fact]
    public void LogTwoDifferentPriorityMessagesSentToAddressee()
    {
        // Assign
        Message message1 = new("From Cat", "meow meow, meow? meowmeow meow meow. Meow", new PriorityLevel(2));
        Message message2 = new("From Obama", "Yes it was me, I did it in elevator...", new PriorityLevel(9999));

        User addressee = new();
        MoqLogger logger = new();
        AddresseeProxy addresseeProxy = new(addressee, new PriorityLevel(3), logger);

        Topic topic = new(addresseeProxy);

        // Act
        topic.Receive(message1);
        topic.Receive(message2);

        // Assert
        Assert.Equal(1, logger.CallCounter);
    }
}
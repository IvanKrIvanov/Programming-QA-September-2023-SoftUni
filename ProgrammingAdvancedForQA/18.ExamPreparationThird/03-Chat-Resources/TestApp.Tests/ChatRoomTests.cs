using System;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        string sender = "Ivan";
        string messege = "Hello";

        // Act
        this._chatRoom.SendMessage(sender, messege);
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain("Ivan: Hello - Sent at "));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange

        // Act
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        string sender = "Ivan";
        string sender2 = "Didi";
        string messege = "Hello";
        string messege2 = "Hi";

        // Act
        this._chatRoom.SendMessage(sender, messege);
        this._chatRoom.SendMessage(sender2, messege2);
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("Ivan: Hello - Sent at "));
        Assert.That(result, Does.Contain("Didi: Hi - Sent at "));
    }
}

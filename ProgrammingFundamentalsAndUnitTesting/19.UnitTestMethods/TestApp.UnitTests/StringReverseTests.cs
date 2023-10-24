using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "X";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("X", result);
        Assert.AreEqual(1, result.Length);

    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "XYZ";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(input.Length, input.Length);
        Assert.AreEqual("ZYX", result);

    }
}

using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("abcdef", 2, "aBcDeFaBcDeF")]
    [TestCase("ABCDEF", 1, "aBcDeF")]
    [TestCase("abcdef", 5, "aBcDeFaBcDeFaBcDeFaBcDeFaBcDeF")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int repelitionFactor = 10;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repelitionFactor),Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abcdef";
        int repelitionFactor = -5;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repelitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abcdef";
        int repelitionFactor = 0;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repelitionFactor), Throws.ArgumentException);
    }
}

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange 
        string input = "";

        // Act 
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange 
        string input = "test";

        // Act 
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo("test"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange 
        string input = "SoftUni rocks";

        // Act 
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo("softuniRocks"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange 
        string input = "IMPORTANT: DO NOT REMOVE OR CHANGE";

        // Act 
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo("important:DoNotRemoveOrChange"));
    }
}

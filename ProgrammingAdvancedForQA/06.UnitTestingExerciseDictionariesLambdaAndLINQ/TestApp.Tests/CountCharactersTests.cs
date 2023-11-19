using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() {  "a" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("a -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aaa", "aabbccc", "abcbba" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 7");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");
        string expexted = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expexted));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa!a", "!aabbc!cc", "abc!bcba" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 7");
        sb.AppendLine("! -> 4");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 5");
        string expexted = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expexted));
    }
    [Test]
    public void Test_Count_WithUpperCaseAndNumberCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa!a", "!aabbc!cc", "abc!bcba", "ABC123", "CBA123", "BCA123" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 7");
        sb.AppendLine("! -> 4");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 5");
        sb.AppendLine("A -> 3");
        sb.AppendLine("B -> 3");
        sb.AppendLine("C -> 3");
        sb.AppendLine("1 -> 3");
        sb.AppendLine("2 -> 3");
        sb.AppendLine("3 -> 3");
        string expexted = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expexted));
    }
}

﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31-Dec-2022 random text";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "Invalid date format";
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "19.Jan.2015 31-Dec-2022  text";
        string expected = "Day: 19, Month: Jan, Year: 2015";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => MatchDates.Match(input), Throws.ArgumentException);
    }
}

using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 5;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result.Keys.Count, Is.EqualTo(1));
        Assert.That(result.ContainsKey(5), Is.True);
        Assert.That(result[5], Is.EqualTo(1));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 35353532;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result.ContainsKey(3), Is.True);
        Assert.That(result[3], Is.EqualTo(4));

        Assert.That(result.ContainsKey(5), Is.True);
        Assert.That(result[5], Is.EqualTo(3));

        Assert.That(result.ContainsKey(2), Is.True);
        Assert.That(result[2], Is.EqualTo(1));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -2323233;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result.ContainsKey(2), Is.True);
        Assert.That(result[2], Is.EqualTo(3));

        Assert.That(result.ContainsKey(3), Is.True);
        Assert.That(result[3], Is.EqualTo(4));
    }
}

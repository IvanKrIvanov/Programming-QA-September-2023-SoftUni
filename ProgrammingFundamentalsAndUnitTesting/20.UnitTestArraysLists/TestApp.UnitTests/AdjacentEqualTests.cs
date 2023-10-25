﻿using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{

    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }


    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4, 3, 5 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 3 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new() { 1, 2, 2, 4, 3, 5 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 8 3 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> list = new() { 1, 1, 2, 4 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {        
        // Arrange
        List<int> list = new() { 6, 4, 2, 4 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("6 4 2 4"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4, 4 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 3, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 6 4 5"));
    }
}

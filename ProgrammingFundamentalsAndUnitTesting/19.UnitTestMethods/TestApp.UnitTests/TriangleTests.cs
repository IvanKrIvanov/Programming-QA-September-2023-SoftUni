using NUnit.Framework;
using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        int input = 0;

        // Act
        string result = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual("", result);

    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        int input = 3;
        string expectedOutpit = "1" +
            "" + Environment.NewLine +
            "1 2" + Environment.NewLine + 
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";

        // Act
        string result = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual(expectedOutpit, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        int input = 5;
        string expectedOutpit = "1" +
            "" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3 4 5" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";

        // Act
        string result = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual(expectedOutpit, result);
    }
}

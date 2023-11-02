using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = null;

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);

    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = "";

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "C:\\Users\\demo.txt";
        string expected = "File name: demo\nFile extension: txt";

        // Act
        string output = ExtractFile.GetFile(path);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = "C:\\Users\\demo";
        string expected = "File name: demo";

        // Act
        string output = ExtractFile.GetFile(path);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "C:\\Us#e$r!s\\demo.txt";
        string expected = "File name: demo\nFile extension: txt";

        // Act
        string output = ExtractFile.GetFile(path);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}

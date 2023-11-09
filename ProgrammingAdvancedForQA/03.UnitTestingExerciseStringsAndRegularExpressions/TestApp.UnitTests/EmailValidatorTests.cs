using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("ivan_ivanov@softuni.bg")]
    [TestCase("petarpetrov@abv.bg")]
    [TestCase("angel123@gmail.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("ivan ivanov@abv.bg")]
    [TestCase("ivan%ivanov@g_mail.com")]
    [TestCase("invalid/mail@invalid.d")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}

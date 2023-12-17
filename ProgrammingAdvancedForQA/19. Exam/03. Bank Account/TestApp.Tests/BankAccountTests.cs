using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double balance = 100.0;

        // Act
        BankAccount account = new BankAccount(balance);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(balance));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double balance = 100.0;
        double depositAmount = 50.0;
        BankAccount account = new BankAccount(balance);

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(balance + depositAmount));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double balance = 100.0;
        double negativeDepositAmount = -50.0;
        BankAccount account = new BankAccount(balance);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Deposit(negativeDepositAmount));
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double balance = 100.0;
        double withdrawalAmount = 30.0;
        BankAccount account = new BankAccount(balance);

        // Act
        account.Withdraw(withdrawalAmount);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(balance - withdrawalAmount));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100.0;
        double negativeWithdrawalAmount = -30.0;
        BankAccount account = new BankAccount(initialBalance);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(negativeWithdrawalAmount));
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100.0;
        double withdrawalAmount = 150.0;
        BankAccount account = new BankAccount(initialBalance);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawalAmount));
    }
}

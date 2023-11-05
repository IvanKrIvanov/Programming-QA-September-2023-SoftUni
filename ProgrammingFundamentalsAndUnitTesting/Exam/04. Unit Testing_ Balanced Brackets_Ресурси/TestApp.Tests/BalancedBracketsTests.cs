using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        string[] input = { };
        bool result = BalancedBrackets.IsBalanced(input);
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        string[] input = { "(", ")", "(", ")", "(", ")" };
        bool result = BalancedBrackets.IsBalanced(input);
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        string[] input = { "(", ")", ")", ")" };
        bool result = BalancedBrackets.IsBalanced(input);
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        string[] input = { "(", ")", ")", ")" };
        bool result = BalancedBrackets.IsBalanced(input);
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        string[] input = { "(", "(" };
        bool result = BalancedBrackets.IsBalanced(input);
        Assert.IsFalse(result);
    }
}

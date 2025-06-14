using Xunit;
using UnitTestingDemo.Core;
namespace UnitTestingDemo.Tests;

public class CalculatrorTests
{
    [Fact]
    public void Multiply_TowPositiveNumbers_ReturnsCorrectProduct()
    {
        int a = 3;
        int b = 2;
        int result = Calculatror.Multiply(a, b);
        Assert.Equal(6, result);
    }
    [Fact]
    public void Multiply_NumberWithZero_ReturnsZero()
    {
        // Arrange
        int a = 0, b = 5;

        // Act
        int result = Calculatror.Multiply(a, b);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_NegativeAndPositiveNumber_ReturnsNegative()
    {
        // Arrange
        int a = -2, b = 3;

        // Act
        int result = Calculatror.Multiply(a, b);

        // Assert
        Assert.Equal(-6, result);
    }

    [Fact]
    public void Multiply_TwoNegativeNumbers_ReturnsPositive()
    {
        // Arrange
        int a = -2, b = -3;

        // Act
        int result = Calculatror.Multiply(a, b);

        // Assert
        Assert.Equal(6, result);
    }
    [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 10;
        int b = 2;

        // Act
        int result = Calculatror.Divide(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculatror.Divide(a, b));
    }

    [Fact]
    public void Divide_NegativeNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = -10;
        int b = 2;

        // Act
        int result = Calculatror.Divide(a, b);

        // Assert
        Assert.Equal(-5, result);
    }

    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        // Arrange
        int number = 4;

        // Act
        bool result = Calculatror.IsEven(number);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        // Arrange
        int number = 5;

        // Act
        bool result = Calculatror.IsEven(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsEven_Zero_ReturnsTrue()
    {
        // Arrange
        int number = 0;

        // Act
        bool result = Calculatror.IsEven(number);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEven_NegativeEvenNumber_ReturnsTrue()
    {
        // Arrange
        int number = -4;

        // Act
        bool result = Calculatror.IsEven(number);

        // Assert
        Assert.True(result);
    }
}
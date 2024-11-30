using EventPlanner.Shared.Core.Domain.ValueObjects;
using EventPlanner.Shared.Core.Exceptions;
using FluentAssertions;

namespace EventPlanner.Shared.Core.UnitTests.ValueObjects;

public class MoneyTests
{
    [Fact]
    public void WithValidAmount_ShouldCreate()
    {
        // Arrange
        var amount = 10.0m;

        // Act
        var money = Money.Create(amount);

        // Assert
        money.Value.Should().Be(amount);
    }
    
    [Fact]
    public void WhenAddingTwoMoney_ShouldReturnSum()
    {
        // Arrange
        var money1 = Money.Create(10.0m);
        var money2 = Money.Create(20.0m);
        
        var expectedSum = 30.0m;

        // Act
        var sum = money1 + money2;

        // Assert
        sum.Value.Should().Be(expectedSum);
    }
    
    [Fact]
    public void WhenSubtractingTwoMoney_ShouldReturnDifference()
    {
        // Arrange
        var money1 = Money.Create(30.0m);
        var money2 = Money.Create(20.0m);
        
        var expectedDifference = 10.0m;

        // Act
        var difference = money1 - money2;

        // Assert
        difference.Value.Should().Be(expectedDifference);
    }
    
    [Fact]
    public void WhenMultiplyingMoneyByMultiplier_ShouldReturnProduct()
    {
        // Arrange
        var money = Money.Create(10.0m);
        var multiplier = 2.0m;
        
        var expectedProduct = 20.0m;

        // Act
        var product = money * multiplier;

        // Assert
        product.Value.Should().Be(expectedProduct);
    }
    
    [Fact]
    public void WhenConvertingDecimalToMoney_ShouldReturnMoney()
    {
        // Arrange
        var amount = 10.0m;

        // Act
        Money money = amount;

        // Assert
        money.Value.Should().Be(amount);
    }
}
using EventPlanner.Shared.Core.Domain.ValueObjects;
using EventPlanner.Shared.Core.Exceptions;
using FluentAssertions;

namespace EventPlanner.Shared.Core.UnitTests.ValueObjects;

public class EmailAddressTests
{
    [Fact]
    public void WithValidEmailAddressValue_ShouldCreate()
    {
        // Arrange
        var emailAddressValue = "jdoe@something.com";
        
        // Act
        var emailAddress = EmailAddress.Create(emailAddressValue);
        
        // Assert
        emailAddress.Value.Should().Be(emailAddressValue);
    }
    
    [Fact]
    public void WithInvalidEmailAddressValue_ShouldThrowBadRequestException()
    {
        // Arrange
        var invalidEmailAddressValue = "jdoe@something";
        
        // Act
        var action = new Action(() => EmailAddress.Create(invalidEmailAddressValue));
        
        // Assert
        action.Should().Throw<BadRequestException>();
    }

    [Fact]
    public void WhenComparingTwoEmailAddressesWithSameValue_ShouldReturnTrue()
    {
        // Arrange
        
        string emailAddressValue = "jdoe@something.com";
        
        var emailAddress1 = EmailAddress.Create(emailAddressValue);
        var emailAddress2 = EmailAddress.Create(emailAddressValue);
        
        // Act
        var areEqual = emailAddress1 == emailAddress2;
        
        // Assert
        areEqual.Should().BeTrue();
    }

    [Fact]
    public void WhenComparingTwoEmailAddressesWithDifferentValue_ShouldReturnFalse()
    {
        // Arrange

        string emailAddressValue1 = "jdoe@something.com";
        string emailAddressValue2 = "jdoe@somethingelse.com";

        var emailAddress1 = EmailAddress.Create(emailAddressValue1);
        var emailAddress2 = EmailAddress.Create(emailAddressValue2);
        
        // Act
        var areEqual = emailAddress1 == emailAddress2;
        
        // Assert
        areEqual.Should().BeFalse();
    }
}
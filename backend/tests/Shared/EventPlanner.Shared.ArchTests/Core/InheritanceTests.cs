using EventPlanner.Shared.Core.Exceptions;

namespace EventPlanner.Shared.ArchTests.Core;

public class InheritanceTests
{
    [Fact]
    public void CustomException_ShouldInheritFromBaseException()
    {
        // Arrange
        var coreAssembly = typeof(BaseException).Assembly;
        
        // Act
        var result = Types.InAssembly(coreAssembly)
            .That()
            .ResideInNamespace("EventPlanner.Shared.Core.Exceptions")
            .And().DoNotHaveName(nameof(BaseException))
            .Should()
            .Inherit(typeof(BaseException))
            .GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
using EventPlanner.Shared.Abstractions;

namespace EventPlanner.Shared.ArchTests.Abstractions;

public class AbstractionLayerTests
{
    [Fact]
    public void SharedAbstractions_Should_NotHaveReferenceToCore()
    {
        // Arrange
        var abstractionsAssembly = typeof(IAssemblyReference).Assembly;

        // Act
        var result = Types.InAssembly(abstractionsAssembly)
            .That()
            .ResideInNamespace("EventPlanner.Shared.Abstractions")
            .Should()
            .BeInterfaces()
            .GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
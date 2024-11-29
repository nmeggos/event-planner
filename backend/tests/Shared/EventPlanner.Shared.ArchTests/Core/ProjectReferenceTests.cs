using EventPlanner.Shared.Abstractions.CQRS.Commands;
using EventPlanner.Shared.Core.Exceptions;

namespace EventPlanner.Shared.ArchTests.Core;

public class ProjectReferenceTests
{
    [Fact]
    public void SharedAbstractions_Should_NotHaveReferenceToCore()
    {
        // Arrange
        var abstractAssembly = typeof(ICommand<>).Assembly;

        // Act
        var result = Types.InAssembly(abstractAssembly)
            .ShouldNot()
            .HaveDependencyOn(typeof(BaseException).Assembly.FullName)
            .GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}

using EventPlanner.Modules.VenueManagement.API;
using EventPlanner.Modules.VenueManagement.Application;
using EventPlanner.Modules.VenueManagement.Domain;
using EventPlanner.Modules.VenueManagement.Infrastructure;

namespace EventPlanner.Modules.ArchTests.VenueManagement;

public class ProjectReferenceTests
{
    private readonly ApiAssemblyReference _apiAssemblyReference;
    private readonly ApplicationAssemblyReference _applicationAssemblyReference;
    private readonly DomainAssemblyReference _domainAssemblyReference;
    private readonly InfrastructureAssemblyReference _infrastructureAssemblyReference;

    public ProjectReferenceTests()
    {
        _apiAssemblyReference = new ApiAssemblyReference();
        _applicationAssemblyReference = new ApplicationAssemblyReference();
        _domainAssemblyReference = new DomainAssemblyReference();
        _infrastructureAssemblyReference = new InfrastructureAssemblyReference();
    }


    [Fact]
    public void DomainLayer_Should_NotHaveDependenciesOnDefinedProjectLayers()
    {
        // Arrange
        var assemblies = new[] { _apiAssemblyReference.Name, _applicationAssemblyReference.Name, _infrastructureAssemblyReference.Name };
        
        // Act
        var result = Types.InAssembly(_domainAssemblyReference.Assembly)
            .Should()
            .NotHaveDependencyOnAll(assemblies)
            .GetResult();
        
        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void ApplicationLayer_Should_NotHaveDependenciesOnDefinedProjectLayers()
    {
        // Arrange
        var assemblies = new[] { _apiAssemblyReference.Name, _infrastructureAssemblyReference.Name };
        
        // Act
        var result = Types.InAssembly(_applicationAssemblyReference.Assembly)
            .Should()
            .NotHaveDependencyOnAll(assemblies)
            .GetResult();
        
        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void InfrastructureLayer_Should_NotHaveDependenciesOnDefinedProjectLayers()
    {
        // Arrange
        var assemblies = new[] { _apiAssemblyReference.Name, _applicationAssemblyReference.Name };
        
        // Act
        var result = Types.InAssembly(_infrastructureAssemblyReference.Assembly)
            .Should()
            .NotHaveDependencyOnAll(assemblies)
            .GetResult();
        
        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
using EventPlanner.Modules.EventManagement.API;
using EventPlanner.Modules.EventManagement.Application;
using EventPlanner.Modules.EventManagement.Domain;
using EventPlanner.Modules.EventManagement.Infrastructure;
using FluentAssertions;

namespace EventPlanner.Modules.EventManagement.ArchTests;

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
    public void DomainLayer_ShouldNot_HaveDependencyOn_InfrastructureLayer()
    {
        var result = Types.InAssembly(_domainAssemblyReference.Assembly)
            .Should()
            .NotHaveDependencyOn(_applicationAssemblyReference.Name)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void DomainLayer_ShouldNot_HaveDependencyOn_ApplicationLayer()
    {
        var result = Types.InAssembly(_domainAssemblyReference.Assembly)
            .Should()
            .NotHaveDependencyOn(_applicationAssemblyReference.Name)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void DomainLayer_ShouldNot_HaveDependencyOn_ApiLayer()
    {
        var result = Types.InAssembly(_domainAssemblyReference.Assembly)
            .Should()
            .NotHaveDependencyOn(_apiAssemblyReference.Name)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void ApplicationLayer_ShouldNot_HaveDependencyOn_InfrastructureLayer()
    {
        var result = Types.InAssembly(_applicationAssemblyReference.Assembly)
            .Should()
            .NotHaveDependencyOn(_infrastructureAssemblyReference.Name)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void ApplicationLayer_ShouldNot_HaveDependencyOn_ApiLayer()
    {
        var result = Types.InAssembly(_applicationAssemblyReference.Assembly)
            .Should()
            .NotHaveDependencyOn(_apiAssemblyReference.Name)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void InfrastructureLayer_ShouldNot_HaveDependencyOn_ApiLayer()
    {
        var result = Types.InAssembly(_infrastructureAssemblyReference.Assembly)
            .Should()
            .NotHaveDependencyOn(_apiAssemblyReference.Name)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
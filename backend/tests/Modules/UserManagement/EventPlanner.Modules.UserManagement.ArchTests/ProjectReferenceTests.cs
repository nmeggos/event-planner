namespace EventPlanner.Modules.UserManagement.ArchTests;

public class ProjectReferenceTests
{
    [Fact]
    public void DomainLayer_ShouldNot_HaveDependencyOn_InfrastructureLayer()
    {
        var result = Types.InAssembly(new InfrastructureAssemblyReference().Assembly)
            .That()
            .ResideInNamespace("EventPlanner.Modules.UserManagement.Domain")
            .ShouldNot()
            .HaveDependencyOn("EventPlanner.Modules.UserManagement.Infrastructure")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void DomainLayer_ShouldNot_HaveDependencyOn_ApplicationLayer()
    {
        var result = Types.InAssembly(new ApplicationAssemblyReference().Assembly)
            .That()
            .ResideInNamespace("EventPlanner.Modules.UserManagement.Domain")
            .ShouldNot()
            .HaveDependencyOn("EventPlanner.Modules.UserManagement.Application")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void DomainLayer_ShouldNot_HaveDependencyOn_ApiLayer()
    {
        var result = Types.InAssembly(new ApiAssemblyReference().Assembly)
            .That()
            .ResideInNamespace("EventPlanner.Modules.UserManagement.Domain")
            .ShouldNot()
            .HaveDependencyOn("EventPlanner.Modules.UserManagement.Web")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void ApplicationLayer_ShouldNot_HaveDependencyOn_InfrastructureLayer()
    {
        var result = Types.InAssembly(new InfrastructureAssemblyReference().Assembly)
            .That()
            .ResideInNamespace("EventPlanner.Modules.UserManagement.Application")
            .ShouldNot()
            .HaveDependencyOn("EventPlanner.Modules.UserManagement.Infrastructure")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void ApplicationLayer_ShouldNot_HaveDependencyOn_ApiLayer()
    {
        var result = Types.InAssembly(new ApiAssemblyReference().Assembly)
            .That()
            .ResideInNamespace("EventPlanner.Modules.UserManagement.Application")
            .ShouldNot()
            .HaveDependencyOn("EventPlanner.Modules.UserManagement.Web")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void InfrastructureLayer_ShouldNot_HaveDependencyOn_ApiLayer()
    {
        var result = Types.InAssembly(new ApiAssemblyReference().Assembly)
            .That()
            .ResideInNamespace("EventPlanner.Modules.UserManagement.Infrastructure")
            .ShouldNot()
            .HaveDependencyOn("EventPlanner.Modules.UserManagement.Web")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
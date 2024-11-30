using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EventPlanner.Shared.Abstractions.Registration;

public interface IModuleDefinition
{
    public string Name { get; }
    
    void RegisterDependencies(IServiceCollection services, IConfiguration configuration, IHostEnvironment environment);
    
    void RegisterConfiguration(IConfigurationBuilder configurationBuilder, IHostEnvironment environment);
}
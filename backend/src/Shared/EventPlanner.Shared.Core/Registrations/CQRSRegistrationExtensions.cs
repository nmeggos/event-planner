using System.Reflection;
using EventPlanner.Shared.Abstractions.CQRS;
using EventPlanner.Shared.Core.CQRS;
using Microsoft.Extensions.DependencyInjection;

namespace EventPlanner.Shared.Core.Registrations;

public static class CQRSRegistrationExtensions
{
    public static IServiceCollection AddCQRS(
        this IServiceCollection services,
        Action<IServiceCollection> decorators = null,
        params Assembly[] assemblies)
    {
       var assembliesToScan = assemblies.Any() ? assemblies : new[] { Assembly.GetExecutingAssembly() };

       services.AddMediatR(configure => configure.RegisterServicesFromAssemblies(assembliesToScan));

       services.AddTransient<ICommandExecutor, CommandExecutor>();
       services.AddTransient<IQueryExecutor, QueryExecutor>();
       
       services.AddTransient<IRequestExecutor, RequestExecutor>();
        
       decorators?.Invoke(services);

       return services;
    }
}
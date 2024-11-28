namespace EventPlanner.Shared.Infrastructure.Persistence.Settings;

public class PostgresOptions
{
    public string ConnectionString { get; set; }
    public bool UseInMemory { get; set; }
}
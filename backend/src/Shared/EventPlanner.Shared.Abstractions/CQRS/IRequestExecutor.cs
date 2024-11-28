namespace EventPlanner.Shared.Abstractions.CQRS;

public interface IRequestExecutor : ICommandExecutor, IQueryExecutor
{
    
}
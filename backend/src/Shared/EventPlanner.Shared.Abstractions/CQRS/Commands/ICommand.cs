
namespace EventPlanner.Shared.Abstractions.CQRS.Commands;

public interface ICommand<out TResult> : IRequest<TResult> where TResult : notnull
{
    
}

public interface ICommand : ICommand<Unit>
{
    
}
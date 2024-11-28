namespace EventPlanner.Shared.Abstractions.CQRS.Commands;

public interface ICommandHandler<in TCommand, TResult> 
    where TCommand : ICommand<TResult>
    where TResult : notnull
{
    Task<TResult> HandleAsync(TCommand command, CancellationToken cancellationToken = default);
}

public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, Unit>
    where TCommand : ICommand
{
}
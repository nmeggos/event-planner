namespace EventPlanner.Shared.Abstractions.Domain;

public interface IDomainEventDispatcher
{
    Task DispatchAsync<TDomainEvent>(TDomainEvent domainEvent, CancellationToken cancellationToken)
        where TDomainEvent : IDomainEvent;
}
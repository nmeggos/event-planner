namespace EventPlanner.Shared.Abstractions.Domain;

public interface IDomainEvent : INotification
{
    public DateTime OccurredOn { get; }
}

public interface IDomainEvent<out TAggregateId> : IDomainEvent
{
    public TAggregateId AggregateId { get; }
}
﻿using EventPlanner.Shared.Abstractions.Domain;

namespace EventPlanner.Shared.Core.Domain;

public abstract class AggregateRoot<TId> : Entity<TId>
    where TId : StronglyTypedId<TId>
{
    private readonly List<IDomainEvent> _domainEvents = new();
    
    protected AggregateRoot()
    {
    }
    
    protected AggregateRoot(TId id)
        : base(id)
    {
    }
    
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    
    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
    
    public void ClearDomainEvents() => _domainEvents.Clear();
}
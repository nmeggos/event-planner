namespace EventPlanner.Shared.Core.Domain;

public abstract class Entity<TId> 
    where TId : StronglyTypedId<TId>
{
    protected Entity()
    {
    }
    
    protected Entity(TId id)
    {
        Id = Guard.Against.Null(id, nameof(id));
    }
    
    public TId Id { get; protected set; }
    
    public DateTime CreatedOn { get; protected set; }
    public string CreatedBy { get; protected set; } = string.Empty;

    public override bool Equals(object? obj)
    {
        if (obj is not Entity<TId> other)
        {
            return false;
        }
        
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        
        return Id.Equals(other.Id);
    }
    
    public override int GetHashCode() => Id.GetHashCode();

    public static bool operator ==(Entity<TId> left, Entity<TId> right) => Equals(left, right);
    
    public static bool operator !=(Entity<TId> left, Entity<TId> right) => !(left == right);
}
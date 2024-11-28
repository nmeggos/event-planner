using Ardalis.GuardClauses;

namespace EventPlanner.Shared.Core.Domain.ValueObjects;

public record Money
{
    public decimal Value { get; private set; }
    
    public static Money Create(decimal value)
    {
        return new Money
        {
            Value = value
        };
    }
    
    public static Money operator +(Money left, Money right)
    {
        return Create(left.Value + right.Value);
    }
    
    public static Money operator -(Money left, Money right)
    {
        return Create(left.Value - right.Value);
    }
    
    public static Money operator *(Money money, decimal multiplier)
    {
        return Create(money.Value * multiplier);
    }
    
    public static implicit operator Money(decimal value)
    {
        return Create(value);
    }
    
    public void Deconstruct(out decimal value)
    {
        value = Value;
    }
}
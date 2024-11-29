using Ardalis.GuardClauses;
using EventPlanner.Shared.Core.Guards;

namespace EventPlanner.Shared.Core.Domain.ValueObjects;

public record EmailAddress
{
    public string Value { get; private set; }

    public static EmailAddress Create(string value)
    {
        return new EmailAddress
        {
            Value = Guard.Against.InvalidEmail(value)
        };
    }

    public void Deconstruct(out string value)
    {
        value = Value;
    }
}
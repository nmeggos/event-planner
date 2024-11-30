namespace EventPlanner.Shared.Abstractions;

public interface IAssemblyReference
{
    string Name { get; }
    Assembly Assembly { get; }
}
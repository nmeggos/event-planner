using System.Reflection;

namespace EventPlanner.Shared.Core;

public abstract class AssemblyReferenceBase
{
    public abstract string Name { get; }
    public Assembly Assembly => GetType().Assembly;
}
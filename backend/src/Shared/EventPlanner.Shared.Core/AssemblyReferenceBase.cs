using System.Reflection;
using EventPlanner.Shared.Abstractions;

namespace EventPlanner.Shared.Core;

public abstract class AssemblyReferenceBase : IAssemblyReference
{
    public abstract string Name { get; }
    public Assembly Assembly => GetType().Assembly;
}
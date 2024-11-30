namespace EventPlanner.Modules.EventManagement.Domain;

public class DomainAssemblyReference : AssemblyReferenceBase
{
    public override string Name => typeof(DomainAssemblyReference).Namespace!;
}
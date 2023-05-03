using Facade.Scheme.Systems;

namespace Facade.Scheme;

/// <summary>
/// Uses the system
/// </summary>
public class Client
{
    public void Execute()
    {
        var facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
        
        facade.Operation1();
        facade.Operation2();
    }
}
using Facade.Scheme.Systems;

namespace Facade.Scheme;

/// <summary>
/// A facade which provides the interface to client 
/// </summary>
public class Facade
{
    private SubsystemA _subsystemA;
    private SubsystemB _subsystemB;
    private SubsystemC _subsystemC;

    public Facade(
    SubsystemA subsystemA, 
    SubsystemB subsystemB, 
    SubsystemC subsystemC)
    {
        _subsystemA = subsystemA;
        _subsystemB = subsystemB;
        _subsystemC = subsystemC;
    }

    public void Operation1()
    {
        _subsystemA.ActionA();
        _subsystemB.ActionB();
        _subsystemC.ActionC();
    }
    
    public void Operation2()
    {
        _subsystemB.ActionB();
        _subsystemC.ActionC();
    }
}
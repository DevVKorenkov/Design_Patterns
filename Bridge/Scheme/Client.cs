using Bridge.Scheme.Abstraction;
using Bridge.Scheme.Implementors;

namespace Bridge.Scheme;

public class Client
{
    public void Execute()
    {
        CommonAbstraction abstraction;
        abstraction = new RefinedAbstraction(new SpecificImplementor());
        abstraction.Operation();
        abstraction.Implementor = new SpecificImplementor1();
        abstraction.Operation();
    }
}
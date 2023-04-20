using Protorype.Scheme.Abstract;
using Protorype.Scheme.Prototypes;

namespace Protorype.Scheme;

public class Client
{
    public void Operation()
    {
        IPrototype prototype = new SpecificPrototype1();
        IPrototype clone = prototype.Clone();
        prototype = new SpecificPrototype2();
        clone = prototype.Clone();
    }
}

using Prototype.Scheme.Abstract;
using Prototype.Scheme.Prototypes;

namespace Prototype.Scheme;

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

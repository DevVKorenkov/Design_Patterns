using Protorype.Scheme.Abstract;

namespace Protorype.Scheme.Prototypes;

public class SpecificPrototype1 : IPrototype
{
    public IPrototype Clone()
    {
        return new SpecificPrototype1();
    }
}

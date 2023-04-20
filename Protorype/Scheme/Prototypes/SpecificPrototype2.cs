using Protorype.Scheme.Abstract;

namespace Protorype.Scheme.Prototypes;

public class SpecificPrototype2 : IPrototype
{
    public IPrototype Clone()
    {
        return new SpecificPrototype2();
    }
}

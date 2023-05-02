using Prototype.Scheme.Abstract;

namespace Prototype.Scheme.Prototypes;

/// <summary>
/// Certain object
/// </summary>
public class SpecificPrototype1 : IPrototype
{
    public IPrototype Clone()
    {
        return new SpecificPrototype1();
    }
}

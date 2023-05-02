using Prototype.Scheme.Abstract;

namespace Prototype.Scheme.Prototypes;

/// <summary>
/// Certain object
/// </summary>
public class SpecificPrototype2 : IPrototype
{
    public IPrototype Clone()
    {
        return new SpecificPrototype2();
    }
}

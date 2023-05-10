using Decorator.Scheme.Decorators.Abstraction;

namespace Decorator.Scheme.Decorators;

/// <summary>
/// Defines extra functionality for the base object
/// </summary>
public class SpecificOperationB : AbstractDecorator
{
    public override void Operation()
    {
        base.Operation();
    }
}

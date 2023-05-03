using Decorator.Scheme.Components.Abstract;

namespace Decorator.Scheme.Decorators.Abstraction;

/// <summary>
/// defines Decorator which inherits a component functionality.
/// Also it keeps the link to base component to be decorated.
/// </summary>
public abstract class AbstractDecorator : IComponent
{
    private IComponent _component;

    public void SetComponent(IComponent component)
    {
        _component = component;
    }

    public virtual void Operation()
    {
        if (_component != null)
        {
            _component.Operation();
        }
    }
}

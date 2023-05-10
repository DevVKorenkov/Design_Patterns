using Mediator.Scheme.Mediators.Abstraction;

namespace Mediator.Scheme.Objects.Abstractions;

/// <summary>
/// Defines the interface for interacting with mediator object
/// </summary>
public abstract class AbstractObject
{
    protected IMediator mediator;

    public AbstractObject(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public abstract void Send(string message);

    public abstract void Notify(string message);
}
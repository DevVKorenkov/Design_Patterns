using Mediator.Scheme.Mediators.Abstraction;

namespace Mediator.Scheme.Objects.Abstractions;

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
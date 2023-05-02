using Mediator.Example.Mediators.Abstraction;

namespace Mediator.Example.Members.Abstraction;

public abstract class AbstractMember
{
    protected IMediator _mediator;

    public AbstractMember(IMediator mediator)
    {
        _mediator = mediator;
    }

    public virtual void Send(string message)
    {
        _mediator.Send(message, this);
    }

    public abstract void Notify(string message);
}
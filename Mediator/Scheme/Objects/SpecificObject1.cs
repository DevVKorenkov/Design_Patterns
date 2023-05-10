using Mediator.Scheme.Mediators.Abstraction;
using Mediator.Scheme.Objects.Abstractions;

namespace Mediator.Scheme.Objects;

/// <summary>
/// A certain AbstractObject implementation
/// </summary>
public class SpecificObject1 : AbstractObject
{
    public SpecificObject1(IMediator mediator) : base(mediator)
    {
    }

    public override void Send(string message)
    {
        mediator.Send(message, this);
    }

    public override void Notify(string message)
    {
        
    }
}
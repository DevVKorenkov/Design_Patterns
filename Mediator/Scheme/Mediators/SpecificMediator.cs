using Mediator.Scheme.Mediators.Abstraction;
using Mediator.Scheme.Objects;
using Mediator.Scheme.Objects.Abstractions;

namespace Mediator.Scheme.Mediators;

public class SpecificMediator : IMediator
{
    public SpecificObject SpecificObject { get; set; }
    public SpecificObject SpecificObject1 { get; set; }
    
    public void Send(string message, AbstractObject obj)
    {
        if (SpecificObject == obj)
        {
            SpecificObject1.Notify(message);
        }
        else
        {
            SpecificObject.Notify(message);
        }
    }
}
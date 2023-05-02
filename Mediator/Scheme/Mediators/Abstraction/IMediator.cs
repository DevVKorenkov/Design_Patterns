using Mediator.Scheme.Objects.Abstractions;

namespace Mediator.Scheme.Mediators.Abstraction;

public interface IMediator
{
    void Send(string message, AbstractObject obj);
}
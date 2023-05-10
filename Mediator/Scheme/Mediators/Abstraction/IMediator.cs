using Mediator.Scheme.Objects.Abstractions;

namespace Mediator.Scheme.Mediators.Abstraction;

/// <summary>
/// Defines the interface for objects interacting.
/// </summary>
public interface IMediator
{
    void Send(string message, AbstractObject obj);
}
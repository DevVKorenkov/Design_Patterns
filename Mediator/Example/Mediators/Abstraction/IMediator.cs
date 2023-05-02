using Mediator.Example.Members.Abstraction;

namespace Mediator.Example.Mediators.Abstraction;

public interface IMediator
{
    void Send(string message, AbstractMember member);
}
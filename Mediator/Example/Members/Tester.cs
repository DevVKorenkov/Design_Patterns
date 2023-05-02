using Mediator.Example.Mediators.Abstraction;
using Mediator.Example.Members.Abstraction;

namespace Mediator.Example.Members;

public class Tester : AbstractMember
{
    public Tester(IMediator mediator) : base(mediator)
    {
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"Message to tester: {message}");
    }
}
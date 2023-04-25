using Command.Scheme.Commands;
using Command.Scheme.Invoke;

namespace Command.Scheme;

public class Client
{
    public void Proceed()
    {
        var invoker = new Invoker();
        var receiver = new Receiver();
        var command = new SpecificCommand(receiver);
        invoker.Command = command;
        invoker.Run();
    }
}
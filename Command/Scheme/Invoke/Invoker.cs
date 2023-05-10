using Command.Scheme.Commands.Abstraction;

namespace Command.Scheme.Invoke;

/// <summary>
/// Command initiator. Invokes a command for executing a certain request.
/// </summary>
public class Invoker
{
    public ICommand Command { private get; set; }

    public void Run()
    {
        Command.Execute();
    }

    public void Cancel()
    {
        Command.Undo();
    }
}
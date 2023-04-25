using Command.Scheme.Commands.Abstraction;

namespace Command.Scheme.Invoke;

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
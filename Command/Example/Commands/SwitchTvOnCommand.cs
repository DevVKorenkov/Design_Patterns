using Command.Example.Commands.Abstraction;
using Command.Example.Invoke;
using Command.Example.Invoke.Abstraction;

namespace Command.Example.Commands;

public class SwitchTvOnCommand : ICommand
{
    private IInvoke _receiver;
    
    public SwitchTvOnCommand(IInvoke receiver)
    {
        _receiver = receiver;
    }
    public void Execute()
    {
        _receiver.PositiveAction();
    }

    public void Undo()
    {
        _receiver.NegativeAction();
    }
}
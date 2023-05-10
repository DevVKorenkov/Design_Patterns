using Command.Scheme.Commands.Abstraction;
using Command.Scheme.Invoke;

namespace Command.Scheme.Commands;

/// <summary>
/// Certain command
/// </summary>
public class SpecificCommand : ICommand
{
    private Receiver _receiver;
    public SpecificCommand(Receiver receiver)
    {
        _receiver = receiver;
    }
    
    public void Execute()
    {
        _receiver.Operation();
    }

    public void Undo()
    {
        
    }
}
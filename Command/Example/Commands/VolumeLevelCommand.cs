using Command.Example.Commands.Abstraction;
using Command.Example.Invoke.Abstraction;

namespace Command.Example.Commands;

public class VolumeLevelCommand : ICommand
{
    private IInvoke _volume;

    public VolumeLevelCommand(IInvoke volume)
    {
        _volume = volume;
    }
    
    public void Execute()
    {
        _volume.PositiveAction();
    }

    public void Undo()
    {
        _volume.NegativeAction();
    }
}
using Command.Example.Commands.Abstraction;

namespace Command.Example.Invoke;

// This is the invoker
public class Remote
{
    //public ICommand Command {private get; set;}
    private ICommand[] _commands; // Should change it to a dictionary
    private Stack<ICommand> _commandHistory;

    public Remote()
    {
        _commands = new ICommand[3];
        _commandHistory = new Stack<ICommand>();
    }

    public void SetCommand(int commandPosition, ICommand command)
    {
        _commands[commandPosition] = command;
    }

    public void PressButton(int commandPosition)
    {
        if (_commands[commandPosition] != null)
        {
            _commands[commandPosition].Execute();
            _commandHistory.Push(_commands[commandPosition]);
        }
    }

    public void PressUndo()
    {
        if (_commandHistory.Count > 0)
        {
            var command = _commandHistory.Pop();
            command.Undo();
        }
    }
}
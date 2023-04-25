namespace Command.Scheme.Commands.Abstraction;

public interface ICommand
{
    void Execute();
    void Undo();
}
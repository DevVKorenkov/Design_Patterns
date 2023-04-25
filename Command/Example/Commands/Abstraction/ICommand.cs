namespace Command.Example.Commands.Abstraction;

public interface ICommand
{
    void Execute();
    void Undo();
}
namespace Command.Scheme.Commands.Abstraction;

/// <summary>
/// Defines the command. Usually has Execute method to execute an action
/// and often includes Undo method
/// </summary>
public interface ICommand
{
    void Execute();
    void Undo();
}
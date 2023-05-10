namespace State.Scheme.States.Abstraction;

/// <summary>
/// Defines the interface of the state
/// </summary>
public interface IState
{
    void Handle(Context context);
}
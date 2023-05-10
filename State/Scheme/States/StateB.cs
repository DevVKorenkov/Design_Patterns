using State.Scheme.States.Abstraction;

namespace State.Scheme.States;

/// <summary>
/// certain Implementation of the State
/// </summary>
public class StateB : IState
{
    public void Handle(Context context)
    {
        context.State = new StateA();
    }
}
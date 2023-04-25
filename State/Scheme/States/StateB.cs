using State.Scheme.States.Abstraction;

namespace State.Scheme.States;

public class StateB : IState
{
    public void Handle(Context context)
    {
        context.State = new StateA();
    }
}
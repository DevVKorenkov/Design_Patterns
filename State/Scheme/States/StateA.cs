using State.Scheme.States.Abstraction;

namespace State.Scheme.States;

public class StateA : IState
{
    public void Handle(Context context)
    {
        context.State = new StateB();
    }
}
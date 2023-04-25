using State.Scheme.States.Abstraction;

namespace State.Scheme;

public class Context
{
    public IState State { get; set; }

    public Context(IState state)
    {
        State = state;
    }

    public void Requert()
    {
        State.Handle(this);
    }
}